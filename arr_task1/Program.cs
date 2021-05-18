using System;
using System.Linq;
using System.Collections.Generic;

namespace arr_task1 
{
    class Program
    {
        static void Main(string[] args)
        {
            arr_task1v2();
        }

        //Ввести n целых чисел (n задается пользователем). Какая цифра встречается чаще других? Если таких цифр несколько
        //вывести ту из них, которая обозначает наибольшее число, а также сколько раз она встретилась.
        static void arr_task1()//через строку и линк
        {
            Console.WriteLine("Введите массив чисел, разделяя их пробелами.");
            string readString = System.Console.ReadLine();
            var sortedString = readString.Split(" ").Where(i => i != "").OrderBy(i => int.Parse(i)).GroupBy(i => i).OrderBy(i => i.Count()).ToList();
            Console.WriteLine(sortedString[sortedString.Count() - 1].Key + "-самое большое число, встречаемое наибольшее количество раз: " + sortedString[sortedString.Count() - 1].Count());
        }

        static void arr_task1v2()//через массив и линк
        {
            Console.WriteLine("Введите длину массива");
            string n = Console.ReadLine();
            try
            {
                int[] input = new int[int.Parse(n)];
                for (int i = 0; i < input.Length; i++)
                    input[i] = int.Parse(System.Console.ReadLine());
                Array.Sort(input);
                var groupedInput = input.GroupBy(i => i).OrderBy(i => i.Count()).ToArray();
                Console.WriteLine(groupedInput[groupedInput.Count() - 1].Key + "-самое большое число, встречаемое наибольшее количество раз: " + groupedInput[groupedInput.Count() - 1].Count());
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Некорректный формат данных.");
            }
            catch (System.IndexOutOfRangeException)
            {
                System.Console.WriteLine("Ноль не может быть длиной массива.");
            }
        }

        static void arr_task1v3()//чисто массив без линка
        {

            int maxCount = 0;
            int maxDigit = 0;
            int position = 0;

            Console.WriteLine("Введите длину массива");
            string n = Console.ReadLine();
            try
            {
                int[] input = new int[int.Parse(n)];
                int[] uniqueDigit = new int[int.Parse(n)];
                int[] countOfUniqueDigit = new int[int.Parse(n)];

                for (int i = 0; i < input.Length; i++)
                    input[i] = int.Parse(System.Console.ReadLine());

                //Array.Sort(input); //мы не ищем лёгких путей
                int temp;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[i] > input[j])
                        {
                            temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }

                uniqueDigit[0] = input[0];
                countOfUniqueDigit[0] = 1;

                if (input.Length != 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        if (input[i] != input[i - 1])
                            uniqueDigit[++position] = input[i];
                        countOfUniqueDigit[position]++;
                        if (maxCount <= countOfUniqueDigit[position])
                        {
                            maxCount = countOfUniqueDigit[position];
                            maxDigit = uniqueDigit[position];
                        }
                    }
                }
                else
                {
                    maxCount = input[0];
                    maxDigit = input[0];
                }
                Console.WriteLine(maxDigit + "-самое большое число, встречаемое наибольшее количество раз: " + maxCount);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Недопустимый формат");
                return;
            }
        }
    }
}
