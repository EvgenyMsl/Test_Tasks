using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Task_stars();
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
        static void Task_stars()
        {   
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *
            
            int n2;
            int n = n2 = 5;

            for (int j = 0; j < n2*2; j++)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(' ');
                for (int i = n; i < n2+(n2-n)-1; i++)//добиваем строку до нужного
                    Console.Write('*');
                if (j < n2)
                    n--;
                else
                    n++;
                Console.WriteLine();
            }

        }
    }


}
