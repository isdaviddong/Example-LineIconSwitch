using System;

namespace ConsoleApp1
{
    class Program
    {
        static string ChannelAccessToken = "___換成你自己的ChannelAccessToken___";
        static string AdminUserId = "___換成你自己的AdminUserId___";
        static void Main(string[] args)
        {
            //建立 Bot instance
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);
            //建立文字訊息
            var TextMsg = new isRock.LineBot.TextMessage("嗨，我是老闆");
            TextMsg.sender.name = "老闆"; //改變暱稱
            TextMsg.sender.iconUrl = new Uri("https://i.imgur.com/CkJkfQY.png"); //改變頭像
            bot.PushMessage(AdminUserId, TextMsg);

            //建立文字訊息
            var TextMsg2 = new isRock.LineBot.TextMessage("嗨，我是小編");
            TextMsg2.sender.name = "小編";  //改變暱稱
            TextMsg2.sender.iconUrl = new Uri("https://i.imgur.com/tB236xb.png"); //改變頭像
            bot.PushMessage(AdminUserId, TextMsg2);

            Console.WriteLine("press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
