using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            taskSumFirst3xOdd(); 
        }

        //Ввести n чисел (n задается пользователем). Посчитать сумму трех первых нечетных
        static int taskSumFirst3xOdd()
        {
            int answer = 0;
            int N;

            try
            {
                Console.WriteLine("Введите количество чисел");

                N = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите строку с числами");
                string readString = Console.ReadLine();

                List<String> answerListOfString = readString.Split(" ").Take(N).Where(i => int.Parse(i) % 2 == 1).Take(3).ToList();//парсинг тут не означает вывод не в стринг
                for (int i = 0; i < answerListOfString.Count; i++)
                {
                    answer += int.Parse(answerListOfString[i]);
                }
                Console.WriteLine(answer);
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Во вводе есть не число");
            }
            return answer;
        }

        //Ввести n чисел (n задается пользователем). Посчитать сумму трех первых нечетных.
        static int taskSumFirst3xOddv2()
        {
            int answersum = 0;
            int currentPositionOfDigit = 0;
            int previousPositionOfDigit = 0;
            int iterator = 0;
            string answer = "";
            string readString = "";

            try
            {

                Console.WriteLine("Введите строку с числами");
                readString = Console.ReadLine();

                for (int i = 0; i < readString.Length; i++)
                {
                    if ((readString[i] == ' ') | i == readString.Length)
                    {
                        previousPositionOfDigit = currentPositionOfDigit;
                        currentPositionOfDigit = i;

                        if (readString[currentPositionOfDigit - 1] % 2 == 1)
                        {
                            answer = readString.Substring(previousPositionOfDigit + 1, currentPositionOfDigit - 1 - previousPositionOfDigit);
                            answersum += int.Parse(answer);
                            iterator++;
                            if (iterator == 3)
                                break;
                        }
                    }
                }
                if (answer.Length != 0)
                    Console.WriteLine("Сумма трёх первых нечётных чисел: " + answersum);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неправильный ввод");
            }
            return answersum;
        }
    }

}
