//
//  WebSocketSharpClient.cs
//
//  Author:
//       Jarl Gullberg <jarl.gullberg@gmail.com>
//
//  Copyright (c) 2017 Jarl Gullberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  Lesser General Public License for more details.
//
//  You should have received a copy of the Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Discord.Net;
using Discord.Net.WebSockets;
using JetBrains.Annotations;
using WebSocketSharp;
using SharpSocket = WebSocketSharp.WebSocket;

namespace Discord.Addons.WebSocketSharp
{
	/// <summary>
	/// WebSocket provider using websocket-sharp.
	/// </summary>
	internal class WebSocketSharpClient : IWebSocketClient, IDisposable
	{
		/// <inheritdoc />
		public event Func<byte[], int, int, Task> BinaryMessage;

		/// <inheritdoc />
		public event Func<string, Task> TextMessage;

		/// <inheritdoc />
		public event Func<Exception, Task> Closed;

		private readonly SemaphoreSlim Lock;
		private readonly Dictionary<string, string> Headers;
		private readonly ManualResetEventSlim WaitUntilConnect;

		private SharpSocket Client;
		private CancellationTokenSource CancelTokenSource;
		private CancellationToken CancelToken;
		private CancellationToken ParentToken;

		private bool IsDisposed;

		/// <summary>
		/// Initializes a new instance of the <see cref="WebSocketSharpClient"/> class.
		/// </summary>
		public WebSocketSharpClient()
		{
			this.Headers = new Dictionary<string, string>();
			this.Lock = new SemaphoreSlim(1, 1);
			this.CancelTokenSource = new CancellationTokenSource();
			this.CancelToken = CancellationToken.None;
			this.ParentToken = CancellationToken.None;
			this.WaitUntilConnect = new ManualResetEventSlim();
		}

		/// <inheritdoc />
		public void SetHeader([NotNull] string key, [NotNull] string value)
		{
			this.Headers[key] = value;
		}

		/// <inheritdoc />
		public void SetCancelToken(CancellationToken cancelToken)
		{
			this.ParentToken = cancelToken;
			this.CancelToken = CancellationTokenSource.CreateLinkedTokenSource
			(
				this.ParentToken,
				this.CancelTokenSource.Token
			)
			.Token;
		}

		/// <inheritdoc />
		public async Task ConnectAsync([NotNull] string host)
		{
			await this.Lock.WaitAsync().ConfigureAwait(false);
			try
			{
				await ConnectInternalAsync(host).ConfigureAwait(false);
			}
			finally
			{
				this.Lock.Release();
			}
		}

		private async Task ConnectInternalAsync([NotNull] string host)
		{
			await DisconnectInternalAsync().ConfigureAwait(false);

			this.CancelTokenSource = new CancellationTokenSource();
			this.CancelToken = CancellationTokenSource.CreateLinkedTokenSource
				(
					this.ParentToken,
					this.CancelTokenSource.Token
				)
				.Token;

			this.Client = new SharpSocket(host)
			{
				CustomHeaders = this.Headers.ToList()
			};
			this.Client.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

			this.Client.OnMessage += OnMessage;
			this.Client.OnOpen += OnConnected;
			this.Client.OnClose += OnClosed;

			this.Client.Connect();
			this.WaitUntilConnect.Wait(this.CancelToken);
		}

		/// <inheritdoc />
		public async Task DisconnectAsync()
		{
			await this.Lock.WaitAsync().ConfigureAwait(false);
			try
			{
				await DisconnectInternalAsync().ConfigureAwait(false);
			}
			finally
			{
				this.Lock.Release();
			}
		}

		private Task DisconnectInternalAsync()
		{
			this.CancelTokenSource.Cancel();
			if (this.Client is null)
			{
				return Task.CompletedTask;
			}

			if (this.Client.ReadyState == WebSocketState.Open)
			{
				this.Client.Close();
			}

			this.Client.OnMessage -= OnMessage;
			this.Client.OnOpen -= OnConnected;
			this.Client.OnClose -= OnClosed;

			this.Client = null;
			this.WaitUntilConnect.Reset();

			return Task.CompletedTask;
		}

		private void OnMessage(object sender, MessageEventArgs messageEventArgs)
		{
			if (messageEventArgs.IsBinary)
			{
				OnBinaryMessage(messageEventArgs);
			}
			else if (messageEventArgs.IsText)
			{
				OnTextMessage(messageEventArgs);
			}
		}

		/// <inheritdoc />
		public async Task SendAsync([NotNull] byte[] data, int index, int count, bool isText)
		{
			await this.Lock.WaitAsync(this.CancelToken).ConfigureAwait(false);
			try
			{
				if (isText)
				{
					this.Client.Send(Encoding.UTF8.GetString(data, index, count));
				}
				else
				{
					this.Client.Send(data.Skip(index).Take(count).ToArray());
				}
			}
			finally
			{
				this.Lock.Release();
			}
		}

		private void OnTextMessage(MessageEventArgs e)
		{
			this.TextMessage?.Invoke(e.Data).GetAwaiter().GetResult();
		}

		private void OnBinaryMessage(MessageEventArgs e)
		{
			this.BinaryMessage?.Invoke(e.RawData, 0, e.RawData.Length).GetAwaiter().GetResult();
		}

		private void OnConnected(object sender, EventArgs e)
		{
			this.WaitUntilConnect.Set();
		}

		private void OnClosed(object sender, CloseEventArgs e)
		{
			if (e.WasClean)
			{
				this.Closed?.Invoke(null).GetAwaiter().GetResult();
				return;
			}

			var ex = new WebSocketClosedException(e.Code, e.Reason);
			this.Closed?.Invoke(ex).GetAwaiter().GetResult();
		}

		/// <inheritdoc />
		public void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}

			DisconnectInternalAsync().GetAwaiter().GetResult();

			((IDisposable)this.Client)?.Dispose();
			this.Client = null;

			this.IsDisposed = true;
		}
	}
}
