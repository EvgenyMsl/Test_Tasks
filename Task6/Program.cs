using System;

namespace Task6
{
    class Program 
    {
        static void Main(string[] args)
        {

            Task6();
        }

        static void Task6()
        {
            int answersum = 0;
            int n = 1;
            for (int i = 6; i <= 46; i += 4)
            {
                answersum += i;
                n++;
            }
            Console.WriteLine(n + " слагаемых и сумма " + answersum);
        }
    }
}
