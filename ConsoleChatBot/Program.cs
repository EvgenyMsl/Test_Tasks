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
            System.Console.WriteLine("");

            string s = new String("");
            while (bot.isFinal == false)
            {
                s = Console.ReadLine();
                System.Console.WriteLine("");
                System.Console.WriteLine(bot.TakeAnswer(s));
            }

        }
    }
}
