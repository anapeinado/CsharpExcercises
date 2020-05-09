using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Telegram.Bot;

namespace COVID19
{
    public static class TelegramBot
    {

        private static TelegramBotClient Bot;
        static void Main(string[] args)
        {

            var covidMyRS = Covid19.doCovidProcess("Spain", "Baleares", "2020-05-01", "2020-05-09");

            string covidCSV = Covid19.buildStringCSV(covidMyRS);

            File.WriteAllText("covidTable.csv", covidCSV, Encoding.UTF8);

            var kf = 135;

            //Bot = new TelegramBotClient("993899170:AAF3bv3SFNIX0wn01C8aHXcZz0El63gP4OQ");

            //Bot.OnMessage += Bot_OnMessage;

            //Bot.StartReceiving();
            //Console.ReadLine();
            //Bot.StopReceiving();


        }

        static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            try
            {

                if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text && validateMessage(e.Message.Text))
                {
                    string result = string.Empty;

                    var messageParameters = e.Message.Text.Split(',');
                    if (messageParameters.Length == 3)
                    {
                        var covidMyRS = Covid19.doCovidProcess(messageParameters[1].TrimStart(), messageParameters[2].TrimStart(), messageParameters[0].TrimStart('/'));

                        result = Covid19.buildStringTelegram(covidMyRS);


                    }
                    else
                    {
                        var covidMyRS = Covid19.doCovidProcess(messageParameters[2].TrimStart(), messageParameters[3].TrimStart(), messageParameters[0].TrimStart('/'), messageParameters[1].TrimStart());

                        result = Covid19.buildStringTelegram(covidMyRS);

                    }


                    Bot.SendTextMessageAsync(e.Message.Chat.Id, result);


                }
                else
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "To recieve the data, the message format must be as follows: YYYY-MM-DD, Country, Region");

                }

            }
            catch (Exception)
            {
                Bot.SendTextMessageAsync(e.Message.Chat.Id, "Error. To recieve the data please, the message format must be as follows: YYYY-MM-DD, Country, Region");

            }



        }

        private static bool validateMessage(string text)
        {

            var messageParameters = text.Split(',');

            if (messageParameters.Length == 3 || messageParameters.Length == 4)
            {
                var date = messageParameters[0].TrimStart('/');
                var dateParameters = date.Split('-');
                var isCorrectYear = dateParameters[0].Length == 4;
                var isCorrectMonth = dateParameters[1].Length == 2;
                var isCorrectDay = dateParameters[2].Length == 2;

                if (isCorrectDay && isCorrectMonth && isCorrectYear)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
