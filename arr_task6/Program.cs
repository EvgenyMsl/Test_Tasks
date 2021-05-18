using System;
using System.IO;

namespace arr_task6 
{
    class Program
    {
        static void Main(string[] args)
        {
            task_6();
        }

        static void task_6()
        {
            string path = @"SomeDir\";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            if (File.Exists($"{path}note.txt"))
            {
                FileStream fstream = File.OpenRead($"{path}note.txt");
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);

                Console.WriteLine(textFromFile);

                var text = textFromFile.Split(" ");

                int[] num = new int[text.Length];
                int k = 0;
                for (int i = 0; i < text.Length; i++)
                    try
                    {
                        num[k] = int.Parse(text[i]);
                        k++;
                    }
                    catch
                    {
                        //можно было бы и не так, но нет смысл обрабатывать этот catch
                    }

                int[] sortedarray = new int[k];
                for (int i = 0; i < k; i++)
                {
                    sortedarray[i] = num[i];
                }

                int temp;
                for (int i = 0; i < sortedarray.Length - 1; i++)
                {
                    for (int j = i + 1; j < sortedarray.Length; j++)
                    {
                        if (sortedarray[i] < sortedarray[j])
                        {
                            temp = sortedarray[i];
                            sortedarray[i] = sortedarray[j];
                            sortedarray[j] = temp;
                        }
                    }
                }
                fstream.Close();

                fstream = new FileStream($"{path}note.txt", FileMode.Truncate);
                StreamWriter writer = new StreamWriter(fstream);
                for (int i = 0; i < sortedarray.Length; i++)
                    writer.Write(sortedarray[i] + " ");
                writer.Close();
            }
            else
                Console.WriteLine("Файла с нужным расположением не существует.");
        }

    }
}
