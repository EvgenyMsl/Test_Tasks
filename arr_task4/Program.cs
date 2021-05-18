using System;

namespace arr_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            task_4();
        }

        static void task_4()  
        {
            int N = 3;
            int[] first_ar = new int[N];
            int[] second_ar = new int[N];
            int[] third_array = new int[N * 2];

            try
            {
                Console.WriteLine("Введите первый упорядоченный массив");
                for (int i = 0; i < N; i++)
                {
                    if (i != 0)
                    {
                        first_ar[i] = int.Parse(System.Console.ReadLine());
                        if (first_ar[i - 1] > first_ar[i])
                        {
                            i--;
                            Console.WriteLine($"Новое значение может быть только больше {first_ar[i - 1]}. Повторите ввод.");
                        }
                    }
                    else
                    {
                        first_ar[i] = int.Parse(System.Console.ReadLine());
                    }
                }

                Console.WriteLine("Введите первый упорядоченный массив");
                for (int i = 0; i < N; i++)
                {
                    if (i != 0)
                    {
                        second_ar[i] = int.Parse(System.Console.ReadLine());
                        if (second_ar[i - 1] > second_ar[i])
                        {
                            i--;
                            Console.WriteLine($"Новое значение может быть только больше {second_ar[i - 1]}. Повторите ввод.");
                        }
                    }
                    else
                    {
                        second_ar[i] = int.Parse(System.Console.ReadLine());
                    }
                }

                int i_pos = 0, j_pos = 0, k_pos = 0;
                while (i_pos < N && j_pos < N)
                {
                    if (first_ar[i_pos] < second_ar[j_pos])
                    {
                        third_array[k_pos] = first_ar[i_pos];
                        i_pos++;
                    }
                    else
                    {
                        third_array[k_pos] = second_ar[j_pos];
                        j_pos++;
                    }
                    k_pos++;
                }
                while (i_pos < N)
                {
                    third_array[k_pos] = first_ar[i_pos];
                    i_pos++; k_pos++;
                }
                while (j_pos < N)
                {
                    third_array[k_pos] = second_ar[j_pos];
                    j_pos++; k_pos++;

                }
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
