using System;
using System.Linq;
using System.Collections.Generic;

namespace arr_task2
{
    class Program 
    {
        static void Main(string[] args)
        {
            arr_task2();
        }

        static string arr_task2()
        {
            bool isDescFlag = false;
            bool isAscFlag = false;
            string readString;

            Console.WriteLine("Введите массив чисел, разделяя их пробелами.");
            readString = System.Console.ReadLine();

            if (readString.Length == 0)
                return "Недопустимый ввод: нет элементов в массиве.";
            if (readString.Length == 1)
                return "Недопустимый ввод. Массив не сортирован ни по возрастанию, ни по убыванию.";

            try
            {
                var ascSortedString = readString.Split(" ").Where(i => i != "").OrderBy(i => int.Parse(i)).ToList();
                var readStringList = readString.Split(" ").Where(i => i != "").ToList();

                for (int i = 0; i < readStringList.Count; i++)
                {
                    if (ascSortedString[i] != readStringList[i])
                    {
                        isAscFlag = false;
                        break;
                    }
                    isAscFlag = true;
                }

                var descSortedString = readString.Split(" ").Where(i => i != "").OrderByDescending(i => int.Parse(i)).ToList();
                for (int i = 0; i < readStringList.Count; i++)
                {
                    if (descSortedString[i] != readStringList[i])
                    {
                        isDescFlag = false;
                        break;
                    }
                    isDescFlag = true;
                }

                string answer = "";
                if (isAscFlag)
                {
                    answer = "Cортирован по возрастанию";
                }
                else
                {
                    answer = "Не сортирован по возрастанию";
                    if (isDescFlag)
                    {
                        answer = "Cортирован по убыванию";
                    }
                    else
                    {
                        answer = "Не сортирован по убыванию";
                    }
                }
                return answer;
            }
            catch (System.FormatException)
            {
                return "Недопустимый ввод.";
            }
        }

    }
}
