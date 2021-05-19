using System;
using System.Collections.Generic;

namespace OOP_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool end = false;
            Library lib = new Library();
            while (!end)
            {
                /*System.Console.WriteLine("Введите команду");
                switch(System.Console.ReadLine())
                {
                    case "1"://add book
                        Book book = new Book();
                        lib.Add(book);
                    break;
                    case "2":// "add journal":
                        Journal journal = new Journal();
                        lib.Add(journal);
                        break;
                    case "3"://"delete book":
                        break;
                    case "4":// "delete journal":
                        break;
                    case "5":// "change book":
                        break;
                    case "6":// "change journal":
                        break;
                    case "-end":
                        end = true;
                        break;
                }*/

                for (int i = 0; i < 1; i++)
                {
                    Book book = new Book();
                    lib.Add(book);
                }

                Journal journal = new Journal();
                lib.Add(journal);
                List<Book> selection = new List<Book>();
                lib.Find("b");
                lib.DeleteSelection();

                lib.Viewall();
                lib.DeleteAll();
                lib.Viewall();
            }
        }
    }
    class Library
    {
        private List<Book> booksList = new List<Book>();
        private List<Journal> journalsList = new List<Journal>();
        private List<Book> selectionBook = new List<Book>();
        private List<Journal> selectionJournal = new List<Journal>();

        private readonly string databasepath = "\\";

        public string Databasepath
        {
            get
            {
                return databasepath;
            }
        }

        void Loadtodatabase()
        {

        }

        void Uploadtodatabase()
        {

        }

        public void Add(Book book)
        {
            booksList.Add(book);
        }

        public void Add(Journal journal)
        {
            journalsList.Add(journal);
        }

        public void DeleteSelection()
        {
            foreach (Book bl in selectionBook)
                booksList.Remove(bl);
            System.Console.WriteLine("Удаление произведено успешно");
        }

        public void DeleteAll()
        {
            foreach (Book bl in booksList)
                booksList.Remove(bl);
            foreach (Journal jl in journalsList)
                journalsList.Remove(jl);
            System.Console.WriteLine("Библиотека удалена");
        }


        public void Find(string typeofstuff)
        {
            System.Console.WriteLine("Введите искомое имя");
            string name = System.Console.ReadLine();

            switch (typeofstuff)
            {
                case "b":
                    {
                        foreach (Book bl in booksList)
                            if (bl.Name == name)
                                selectionBook.Add(bl);
                        break;
                    }

                case "j":
                    {
                        foreach (Journal jl in journalsList)
                            if (jl.Name == name)
                                selectionJournal.Add(jl);
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Введите тип b-Книги j-Журналы");
                        typeofstuff = System.Console.ReadLine();
                        break;

                    }
            }
            ViewSelection(typeofstuff);
        }

        public void Change(string typeofstuff)
        {
            bool iscorrect=false;
            switch (typeofstuff)
            {
                case "b":
                    {
                        if (selectionBook.Count>1)
                        {
                            Chooseone();
                        }
                        else
                        {
                            selectionBook[0].Author = Console.ReadLine();
                            selectionBook[0].Genre = Console.ReadLine();
                            selectionBook[0].Name = Console.ReadLine();
                            selectionBook[0].Publishing = Console.ReadLine();
                            while (!iscorrect)
                            {
                                System.Console.WriteLine("Введите корректный год цифрой");
                                iscorrect = int.TryParse(Console.ReadLine(), out selectionBook[0].Yearofpublishing);
                            }
                            iscorrect = false;

                            while (!iscorrect)
                            {
                                System.Console.WriteLine("Введите корректное количество ");
                                iscorrect = int.TryParse(Console.ReadLine(), out selectionBook[0].Quantity);
                            }
                            iscorrect = false;
                            
                        }
                        break;
                    }
            }
        }

        void Chooseone()
        {

        }

        public void ViewOne(string typeofstuff)
        {
            switch (typeofstuff)
            {
                case "b":
                    {
                        selectionBook[0].Display();
                        break;
                    }
                case "j":
                    {
                        selectionJournal[0].Display();
                        break;
                    }
            }
        }

        public void ViewSelection(string typeofstuff)
        {
            switch (typeofstuff)
            {
                case "b":
                    Console.WriteLine("Книги с выбранным именем:");
                    if (selectionBook.Count != 0)
                    {
                        foreach (Book sb in selectionBook)
                            sb.Display();
                    }
                    else
                    {
                        Console.WriteLine("Книг с выбранным именем нет");
                    }
                    break;
                case "j":
                    if (selectionJournal.Count!=0)
                    {
                        Console.WriteLine("Журналы с выбранным именем:");
                        foreach (Journal sb in selectionJournal)
                            sb.Display();
                    }
                    else
                    {
                        Console.WriteLine("Журналов с выбранным именем нет");
                    }
                    break;
                default:
                    System.Console.WriteLine("Неправильный ввод");
                    break;
            }

        }

        public void Viewall()
        {
            System.Console.WriteLine("BOOKS***************************************");
            if (booksList.Count != 0)
            {
                foreach (Book sb in booksList)
                {
                    sb.Display();
                    System.Console.WriteLine("********************************************");
                }
            }
            else
            {
                System.Console.WriteLine("Предложение отсутствует");
                System.Console.WriteLine("********************************************");
            }
            System.Console.WriteLine("JOURNALS************************************");
            if (journalsList.Count != 0)
            {
                foreach (Journal sj in journalsList)
                {
                    sj.Display();
                    System.Console.WriteLine("********************************************");
                }
            }
            else
            {
                System.Console.WriteLine("Предложение отсутствует");
                System.Console.WriteLine("********************************************");
            }
}
    }

 //    книг известны следующие параметры: код, название,                имеющееся количество, автор, жанр, год издания, издательство.
 //журналов известны следующие параметры: код, название, периодичность, имеющееся количество,                           издательство,  год, номер.              

    abstract class Stuff
    {
        //protected int id; //в литсте и так уникальные значения позиций
        protected internal string Name;
        protected internal int Quantity;
        protected internal string Publishing;

        protected bool iscorrect = false;

        protected Stuff()
        {
            
            System.Console.WriteLine("Введите название");
            Name = Console.ReadLine();

            while (!iscorrect)
            {
                System.Console.WriteLine("Введите корректное количество ");
                iscorrect=int.TryParse(Console.ReadLine(), out Quantity);
            }
            iscorrect = false;
            
            System.Console.WriteLine("Введите издательство");
            Publishing = Console.ReadLine();
        }
        abstract public void Display();
    }

    class Book: Stuff
    {
        protected internal string Author;
        protected internal string Genre;
        protected internal int Yearofpublishing; 

        public Book()
        {
            System.Console.WriteLine("Введите автора книги");
            Author = Console.ReadLine();
            System.Console.WriteLine("Введите жанр книги");
            Genre = Console.ReadLine();
            
            while (!iscorrect)
            {
                System.Console.WriteLine("Введите корректный год их издания");
                iscorrect = int.TryParse(Console.ReadLine(), out Yearofpublishing);
            }
            iscorrect = false;

        }
        override public void Display()
        {
            System.Console.WriteLine($"Наименование: {Name}");
            System.Console.WriteLine($"Имеющееся количество: {Quantity}");
            System.Console.WriteLine($"Издательство: {Publishing}");
            System.Console.WriteLine($"Автор: {Author}");
            System.Console.WriteLine($"Жанр: {Genre}");
            System.Console.WriteLine($"Год издательства: {Yearofpublishing}");
            System.Console.WriteLine("********************************************");
        }
    }

    class Journal: Stuff
    {
        public string Periodicity;
        public int Yearofrelease;
        public int Number;

        public Journal()
        {
            System.Console.WriteLine("Введите периодичность издания");
            Periodicity = Console.ReadLine();
            
            while (!iscorrect)
            {
                System.Console.WriteLine("Введите год издания");
                iscorrect = int.TryParse(Console.ReadLine(), out Yearofrelease);
            }
            iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Введите номер выпуска");
                iscorrect = int.TryParse(Console.ReadLine(), out Number);
            }
            iscorrect = false;
        }

        override public void Display()
        {
            System.Console.WriteLine($"Наименование: {Name}");
            System.Console.WriteLine($"Имеющееся количество: {Quantity}");
            System.Console.WriteLine($"Издательство: {Publishing}");
            System.Console.WriteLine($"Периодичность: {Periodicity}");
            System.Console.WriteLine($"Год выпуска: {Yearofrelease}");
            System.Console.WriteLine($"Номер выпуска: {Number}");
            System.Console.WriteLine("********************************************");

        }
    }

}
