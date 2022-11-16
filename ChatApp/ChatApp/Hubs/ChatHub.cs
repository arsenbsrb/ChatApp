﻿using Microsoft.AspNetCore.SignalR;
namespace ChatApp.Hubs;
public class ChatHub : Hub
{
    public async Task SendMessage(string username, string message) 
    {
        await Clients.All.SendAsync("ReceiveMessage" ,username, message);   
    }
}

