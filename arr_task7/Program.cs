using System;

namespace arr_task7
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = rnd.Next(0,20);
            System.Console.WriteLine(count+" элементов.");
            int n = rnd.Next(0,0xFFFF);
            System.Console.WriteLine($"Сдвиг на {n} элементов.");
            n %= count;

            int[] arr = new int[count];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,0xFFFF);
                System.Console.Write(arr[i] + " ");
            }
            System.Console.WriteLine();

            //можно было бы в N подходов, но не
            // [1 2 3 4] 5 6 7 8 9 10
            //   ----->
            //           <-----
            // 5 6 7 8 9 10 [1 2 3 4]


            int[] temp_arr = new int[n];

            for (int i = 0; i < n; i++)
                temp_arr[i] = arr[i];

            for (int i = n; i < count; i++)
                arr[i - n] = arr[i];

            int k = 0;

            for (int i = count - n; i < count; i++)
            {
                arr[i] = temp_arr[k];
                k++;
            }

            for (int i = 0; i < count; i++)
                System.Console.Write(arr[i] + " ");
            System.Console.WriteLine();

            Console.ReadLine();
        }
    }
}
