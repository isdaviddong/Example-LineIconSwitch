using System;

namespace ConsoleApp1
{
    class Program
    {
        static string ChannelAccessToken = "___換成你自己的ChannelAccessToken___";
        static string AdminUserId = "___換成你自己的AdminUserId___";
        static void Main(string[] args)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);
            var TextMsg = new isRock.LineBot.TextMessage("嗨，我是老闆");
            TextMsg.sender.name = "老闆";
            TextMsg.sender.iconUrl = new Uri("https://i.imgur.com/CkJkfQY.png");
            bot.PushMessage(AdminUserId, TextMsg);

            var TextMsg2 = new isRock.LineBot.TextMessage("嗨，我是小編");
            TextMsg2.sender.name = "小編";
            TextMsg2.sender.iconUrl = new Uri("https://i.imgur.com/tB236xb.png");
            bot.PushMessage(AdminUserId, TextMsg2);

            Console.WriteLine("press enter to continue...");
            Console.ReadLine();
        }
    }
}
