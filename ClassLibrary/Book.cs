using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class ClassLibrary
    {
        static void Main(string[] args)
        {

        }
    }

    public class Book : Stuff, IStuff
    {
        protected internal string Author;
        protected internal string Genre;
        protected internal int Yearofpublishing;

        public Book()
        {
            System.Console.WriteLine("Enter an author of book");
            Author = Console.ReadLine();
            System.Console.WriteLine("Enter ganre of book");
            Genre = Console.ReadLine();

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter correct year of publishing");
                iscorrect = int.TryParse(Console.ReadLine(), out Yearofpublishing);
            }
            iscorrect = false;

        }
        public void Display()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Title: {Name}");
            System.Console.WriteLine($"Quantity: {Quantity}");
            System.Console.WriteLine($"Publishing {Publishing}");
            System.Console.WriteLine($"Author: {Author}");
            System.Console.WriteLine($"Genre: {Genre}");
            System.Console.WriteLine($"Yearofpublishing: {Yearofpublishing}");
            System.Console.WriteLine("********************************************");
        }

        public void Change()
        {
            string strAnswer;
            System.Console.WriteLine("Enter new title of press enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Name = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new corrcet quantity of press enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Quantity) : true;
            }
            iscorrect = false;

            System.Console.WriteLine("Enter new publishing of press enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Publishing = strAnswer;

            System.Console.WriteLine("Enter new author of book or press enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Author = strAnswer;

            System.Console.WriteLine("Enter new genre of book or press enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Genre = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct year of publishing or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Yearofpublishing) : true;
            }
        }
    }
}
