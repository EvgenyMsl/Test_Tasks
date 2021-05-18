using System;
using System.Linq;
using System.Collections.Generic;

namespace arr_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            arr_task3();
        }

        static void arr_task3()
        {

            int minNumPosition = 0;
            int maxNumPosition = 0;

            Console.WriteLine("Введите длину массива");
            string n = Console.ReadLine();

            System.Console.WriteLine("Введите элементы массива в диапазоне от -100 до 100");
            try
            {
                int[] input = new int[int.Parse(n)];
                for (int i = 0; i < input.Length; i++)
                { 
                    input[i] = int.Parse(System.Console.ReadLine());
                    if((input[i]>=100)||(input[i]<=-100))
                    {
                        System.Console.WriteLine("Не правильно значение! Введите еще раз");
                        i--;
                    }
                }

                System.Console.WriteLine("min: " + input.Min());
                System.Console.WriteLine("max: " + input.Max());
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == input.Min())
                        minNumPosition = i;
                    if (input[i] == input.Max())
                        maxNumPosition = i;
                }

                int tmp = input[minNumPosition];
                input[minNumPosition] = input[maxNumPosition];
                input[maxNumPosition] = tmp;
                try
                {
                    System.Console.WriteLine("min odd: " + input.Where(i => i % 2 == 0).Min());
                    System.Console.WriteLine("min even: " + input.Where(i => i % 2 != 0).Min());
                }
                catch (System.InvalidOperationException ex)
                {
                    System.Console.WriteLine("Нет нужных значений для выборки: чётных или не чётных " + ex.Message);
                    return;
                }

                Console.WriteLine("Массив после преобразования: ");

                for (int i = 0; i < input.Length; i++)
                    System.Console.Write(input[i] + " ");

            }
            catch (System.InvalidOperationException ex)
            {
                System.Console.WriteLine("Недопустимый для дальнейших действий ввод " + ex.Message);
                return;
            }
        }
    }
}
