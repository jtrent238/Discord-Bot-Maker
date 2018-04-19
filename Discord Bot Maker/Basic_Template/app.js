const Discord = require('discord.js');
const config = require('./config.json');
const client = new Discord.Client();

client.on('ready',() => {
  console.log('I\'m Online\nI\'m Online');
});

const prefix = '!';
client.on('message', message => {
  if (message.author === client.user) return;
  
  if (message.content.startsWith(prefix + 'ping')) {
      message.channel.sendMessage('Pong!');
  }
    
});

client.login(config.token);