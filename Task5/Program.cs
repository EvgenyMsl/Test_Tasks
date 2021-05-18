using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int answersum=Task5(out number);
        }

        static int Task5(out int number)
        {
            number = 2;
            int answersum = 0;
            int n = 0;
            while (answersum <= 100)
            {

                number += 4;
                n++;
                answersum += number;
            }
            answersum -= number;
            n--;
            Console.WriteLine(n + " слагаемых и сумма " + answersum);
            return answersum;
        }
    }


}
