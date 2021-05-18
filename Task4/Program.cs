using System;
using System.Linq;
using System.Collections.Generic;

namespace Task4 
{
    class Program
    {
        static void Main(string[] args)
        {
            taskSumLast3xOdd();
        }

        static int taskSumLast3xOdd()
        {
            int answer = 0;
            int N;

            try
            {
                Console.WriteLine("Введите количество чисел");
                N = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите строку с числами");
                string readString = Console.ReadLine();

                List<String> answerListOfString = readString.Split(" ").Take(N).Where(i => int.Parse(i) % 2 == 1).Take(3).ToList();//парсинг тут нужен
                answerListOfString.Reverse();
                for (int i = 0; i < answerListOfString.Count; i++)
                {
                    answer += int.Parse(answerListOfString[i]);
                }

                Console.WriteLine("Cумма трех последних нечетных чисел: " + answer);
                Console.ReadLine();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Некорректный ввод.");
            }
            return answer;
        }

        //Ввести n чисел (n задается пользователем). Посчитать сумму трех последних нечетных.
        static int taskSumLast3xOdd4v2()
        {
            int answersum = 0;
            int currentPositionOfDigit = 0;
            int previousPositionOfDigit = 0;
            int prepreviousOddNumber = 0;
            int previousOddNumber = 0;
            int currentOddNumber = 0;
            int NumberOfDigits = 0;
            string digitString = "";

            try
            {

                Console.WriteLine("Введите число N-количество чисел на вход");
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите строку с числами");
                string readString = Console.ReadLine();

                for (int i = 0; i < readString.Length; i++)
                {
                    if ((readString[i] == ' ') | i == readString.Length)
                    {
                        previousPositionOfDigit = currentPositionOfDigit;
                        currentPositionOfDigit = i;
                        NumberOfDigits++;
                        if (NumberOfDigits > N)
                        {
                            Console.WriteLine("Чисел больше, чем заявлено в N. Будем считать последние ДО N");
                            break;
                        }
                        if (readString[currentPositionOfDigit - 1] % 2 == 1)
                        {
                            digitString = readString.Substring(previousPositionOfDigit + 1, currentPositionOfDigit - 1 - previousPositionOfDigit);
                            prepreviousOddNumber = previousOddNumber;
                            previousOddNumber = currentOddNumber;
                            currentOddNumber = int.Parse(digitString);
                        }
                    }
                }
                answersum = currentOddNumber + previousOddNumber + prepreviousOddNumber;

                Console.WriteLine("Сумма трёх последних нечётных чисел" + answersum);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Неправильный ввод");
            }
            return answersum;
        }

    }
}

