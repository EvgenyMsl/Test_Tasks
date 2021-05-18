using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args) 
        {
            task3xNum_v1();
        }

        static int task3xNum_v1()//влоб
        {
            //со стрингой не используя массивы(если стринг не в счёт) и парс
            int answer = 0;
            bool isMinusDigit = false;
            String readIntString = new String("");

            Console.WriteLine("Введите число. Подтверждайте ввод клавишей Enter");
            while (readIntString != "0")
            {
                readIntString = Console.ReadLine();
                for (int i = 0; i < readIntString.Length; i++)
                {
                    if (readIntString[i] == '-')
                        isMinusDigit = true;
                    else
                    {
                        if (isMinusDigit)
                        {
                            if (readIntString.Length != 4)
                            {
                                Console.WriteLine("Неправильный ввод! Введите заново ");
                                answer = 0;
                                break;
                            }
                        }
                        else
                        {
                            if (readIntString.Length != 3)
                            {
                                Console.WriteLine("Неправильный ввод! Введите заново ");
                                answer = 0;
                                break;
                            }
                        }
                        if ((readIntString[i] - 48 >= 0 & readIntString[i] - 48 <= 9))
                        {
                            answer += readIntString[i] - 48;
                        }
                        else
                        {
                            answer = 0;
                            Console.WriteLine("Не число! Введите заново ");
                            break;
                        }
                    }
                }
                Console.WriteLine("Cумма чисел: " + answer);
            }
            return answer;
        }

        //Ввести трехзначное число. Посчитать сумму цифр, вывести на экран
        static void task3xNum_v2()//по хитрому:)
        {
            //не используя массивы вообще. По факты маленький кейлоггер
            ConsoleKeyInfo key;
            int answer = 0;
            int numberOfDigits = 0;

            Console.WriteLine("Введите число. Подтверждайте ввод клавишей Enter");
            do
            {
                key = Console.ReadKey();
                char s = (char)((int)key.Key - 48);
                if ((s >= 0 & s <= 9))
                {
                    numberOfDigits++;
                    answer += s;
                }
                else
                {
                    //answer = 0;
                    //numberOfDigits = 0;  
                }
                if ((int)key.Key == 13)//enter
                {
                    if (numberOfDigits != 3)
                    {
                        numberOfDigits = 0;
                        Console.WriteLine();
                        Console.WriteLine("Неправильный ввод! Введите заново ");
                        answer = 0;
                    }
                    else
                    {
                        numberOfDigits = 0;
                        Console.WriteLine();
                        Console.WriteLine("Cумма чисел: " + answer);
                        answer = 0;
                    }
                }
                if (answer == 0 & s == 0)
                    break;
            }
            while (key.Key != ConsoleKey.Escape); // по нажатию на Escape завершаем цикл
        }

        //Ввести трехзначное число. Посчитать сумму цифр, вывести на экран
        static int task3xNum_v3()
        {
            int answer = 0;//не сохраняя считанные позиции. с парсом
            int readInt = 0;
            String readString = new String("");


            Console.WriteLine("Введите число. Подтверждайте ввод клавишей Enter");

            while (readString != "0")
            {
                readString = Console.ReadLine();
                try
                {
                    readInt = int.Parse(readString);
                    if (readInt < 0)//нет смысла считать минус
                        readInt = 0 - readInt;
                    if ((readInt <= 1000) && (readInt >= -1000))
                    {
                        for (int i = 0; i < readString.Length; i++)
                        {
                            answer += readInt % 10;
                            readInt /= 10;
                        }
                        Console.WriteLine("Cумма чисел: " + answer);
                    }
                    else
                        Console.WriteLine("Число не трёхзначное! Введите заново ");

                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Не число");
                }
            }
            return answer;
        }
    }


}
