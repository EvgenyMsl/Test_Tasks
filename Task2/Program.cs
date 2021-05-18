using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            taskMaxSum();
        }

        static int taskMaxSum()
        {
            int answer = 0;//не сохраняя считанные позиции. с парсом
            int maxAnswer = 0;
            int readInt = 0;

            String readIntString = new String("");

            Console.WriteLine("Введите число. Подтверждайте ввод клавишей Enter");
            while (readIntString != "0")
            {
                readIntString = Console.ReadLine();
                try
                {
                    readInt = int.Parse(readIntString);
                    if (readInt < 0)//нет смысла считать минус
                        readInt = 0 - readInt;
                    for (int i = 0; i < readIntString.Length; i++)
                    {
                        answer += readInt % 10;
                        readInt /= 10;
                    }

                    if (answer > maxAnswer)
                        maxAnswer = answer;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            Console.WriteLine(answer);
            return answer;
        }
    }
}
