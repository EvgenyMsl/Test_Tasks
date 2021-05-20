using System;
using ClassChatBot;

namespace ConsoleChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            System.Console.WriteLine(bot.TakeAnswer("Привет"));
        }
    }
}
