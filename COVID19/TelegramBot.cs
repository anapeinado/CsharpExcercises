using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace COVID19
{
    public static class TelegramBot
    {

        private static TelegramBotClient Bot;


        public static void RunTelegramBot()
        {


            Bot = new TelegramBotClient("993899170:AAF3bv3SFNIX0wn01C8aHXcZz0El63gP4OQ");

            Bot.OnMessage += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();


        }

        static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {

                Bot.SendTextMessageAsync(e.Message.Chat.Id, "Hola!");

            }

        }


    }
}
