﻿using System.Collections.ObjectModel;
using System.Linq;
using Snikmorder.Core.Models;
using Snikmorder.Core.Services;
using Telegram.Bot.Types;
using Game = Snikmorder.Core.Models.Game;

namespace Snikmorder.DesktopClient.GameMock
{
    public class GameHostService
    {
        private readonly MessageHandler MessageHandler;

        public ObservableCollection<TelegramMockUser> Users { get; } = new ObservableCollection<TelegramMockUser>();

        public GameHostService()
        {
            var mockTelegramSender = new MockTelegramSender(this);
            var playerRepository = new PlayerRepository();
            var game = new Game(playerRepository, mockTelegramSender);
            var adminStateMachine = new ApprovalStateMachine(mockTelegramSender, playerRepository, game);
            var playerStateMachine = new PlayerStateMachine(mockTelegramSender, playerRepository, adminStateMachine, game);
            MessageHandler = new MessageHandler(adminStateMachine, playerStateMachine);

            for (var i = 0; i <= 16; i++)
            {
                Users.Add(new TelegramMockUser(i, this, i == 0));
            }
        }

        internal void SendMessage(int userId, string text = null, string imagePath = null)
        {
            var msg = new Message()
            {
                From = new User()
                {
                    Id = userId
                },
                Chat = new Chat()
                {
                    Id = userId,
                },
                Text = text,
            };

            if (imagePath != null)
            {
                msg.Photo = new[]
                {
                    new PhotoSize()
                    {
                        Height = 10,
                        Width = 10,
                        FileId = imagePath,
                    },
                };
            }

            MessageHandler.OnMessage(msg);
        }
    }

    public class MockTelegramSender : ITelegramSender
    {
        private readonly GameHostService _gameHostService;

        public MockTelegramSender(GameHostService gameHostService)
        {
            _gameHostService = gameHostService;
        }
        
        public void SendMessage(int id, string message)
        {
            var telegramMockUser = _gameHostService.Users.FirstOrDefault(x=>x.UserId == id);
            telegramMockUser?.AddMessage(message);
        }

        public void SendImage(int id, string message, string? pictureId)
        {
            var telegramMockUser = _gameHostService.Users.FirstOrDefault(x=>x.UserId == id);
            telegramMockUser?.AddImage(message, pictureId);
        }
    }
}
