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

                for (int i = 0; i < 3; i++)
                {
                    Book book = new Book();
                    lib.Add(book);
                }

                Journal journal = new Journal();
                lib.Add(journal);

                List<Book> selection = new List<Book>();

                lib.Find<Book>();
                lib.Change<Book>();
                lib.DeleteSelection<Book>();

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

        public void DeleteSelection<T>()
        {
            if(typeof(T).Name=="Book")
                foreach (Book bl in selectionBook)
                    booksList.Remove(bl);

            if (typeof(T).Name == "Book")
                foreach (Journal jl in selectionJournal)
                    journalsList.Remove(jl);

            //System.Console.WriteLine("Удаление произведено успешно");
        }

        public void DeleteAll()
        {
            for (int i = 0; i < booksList.Count; i++)
            {
                booksList.Remove(booksList[i]);
            }
            for (int i = 0; i < journalsList.Count; i++)
            {
                journalsList.Remove(journalsList[i]);
            }

            System.Console.WriteLine("Библиотека удалена");
        }


        public void Find<T>()
        {
            System.Console.WriteLine("Введите искомое имя");
            string name = System.Console.ReadLine();
            switch (typeof(T).Name)
            {
                case "Book":
                    {
                        foreach (Book bl in booksList)
                            if (bl.Name == name)
                                selectionBook.Add(bl);
                        ViewSelection<Book>();
                        break;
                    }

                case "Journal":
                    {
                        foreach (Journal jl in journalsList)
                            if (jl.Name == name)
                                selectionJournal.Add(jl);
                        ViewSelection<Journal>();
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Ошибка");
                        break;

                    }
            }
            
        }

        public void Change<T>()
        {
            string strAnswer;
            bool iscorrect=false;
            var type = typeof(T).Name;

            switch (type)
            {
                case "Book":
                    {
                        if (selectionBook.Count>1)
                        {
                            Chooseone<Book>();
                        }
                        else
                        {
                            
                            System.Console.WriteLine("Введите новое название или нажмите enter");
                            strAnswer = Console.ReadLine();
                            if(strAnswer != "")
                            selectionBook[0].Name = strAnswer;

                            while (!iscorrect)
                            {
                                System.Console.WriteLine("Введите новое корректное количество или нажмите enter");
                                strAnswer = Console.ReadLine();
                                iscorrect = (strAnswer != "")? int.TryParse(strAnswer, out selectionBook[0].Quantity) : true; 
                            }
                            iscorrect = false;

                            System.Console.WriteLine("Введите новое издательство или нажмите enter");
                            strAnswer = Console.ReadLine();
                            if (strAnswer != "")
                                selectionBook[0].Publishing = strAnswer;

                            System.Console.WriteLine("Введите автора книги или нажмите enter");
                            strAnswer = Console.ReadLine();
                            if (strAnswer != "")
                                selectionBook[0].Author = strAnswer;

                            System.Console.WriteLine("Введите жанр книги или нажмите enter");
                            strAnswer = Console.ReadLine();
                            if (strAnswer != "")
                                selectionBook[0].Genre = strAnswer;

                            System.Console.WriteLine("Введите корректный год их издания или нажмите enter");
                            while (!iscorrect)
                            {
                                System.Console.WriteLine("Введите корректный год цифрой или нажмите enter");
                                strAnswer = Console.ReadLine();
                                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out selectionBook[0].Yearofpublishing) : true;
                            }
                        }
                        break;
                    }
                case "Journal":
                    {
                        if (selectionJournal.Count > 1)
                        {
                            Chooseone<Journal>();
                        }
                        else
                        {
                                System.Console.WriteLine("Введите название");
                                strAnswer = Console.ReadLine();
                                if (strAnswer != "")
                                    selectionJournal[0].Name=strAnswer;

                                while (!iscorrect)
                                {
                                    System.Console.WriteLine("Введите новое корректное количество ");
                                    strAnswer = Console.ReadLine();
                                    iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out selectionJournal[0].Quantity):true;
 
                                }
                                iscorrect = false;

                                System.Console.WriteLine("Введите издательство");
                                strAnswer = Console.ReadLine();
                                if (strAnswer != "")
                                    selectionJournal[0].Publishing = strAnswer;

                                System.Console.WriteLine("Введите периодичность издания");
                                strAnswer = Console.ReadLine();
                                if (strAnswer != "")
                                    selectionJournal[0].Periodicity = strAnswer;

                                while (!iscorrect)
                                {
                                    System.Console.WriteLine("Введите корректный год цифрой");
                                    strAnswer = Console.ReadLine();
                                    iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out selectionJournal[0].Yearofrelease):true;
                                }
                                iscorrect = false;

                                while (!iscorrect)
                                {
                                    System.Console.WriteLine("Введите корректный номер выпуска");
                                    strAnswer = Console.ReadLine();
                                    iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out selectionJournal[0].Quantity) : true;
                                }
                        }
                        break;
                    }
            }
        }

        void Chooseone<T>() where T: Stuff
        {
            int id = 0;
            bool iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Введите корректный id");
                iscorrect = int.TryParse(Console.ReadLine(), out id);
            }

            iscorrect = false;

            switch (typeof(T).Name)
            {
                case "Book":
                    {
                        foreach (Book b in booksList)
                        {
                            if (id == b.Id)
                            {
                                DeleteSelection<Book>();
                                selectionBook.Add(b);
                                System.Console.WriteLine("КНИГА***************************************");
                                b.Display();
                                break;
                            }
                        }
                        
                    }
                    break;
                case "Journal":
                    {
                        foreach (Journal j in journalsList)
                        {
                            if (id == j.Id)
                            {
                                DeleteSelection<Journal>();
                                System.Console.WriteLine("ЖУРНАЛ**************************************");
                                selectionJournal.Add(j);
                                j.Display();
                                break;
                            }
                        }
                    }
                    break;
            }
        }

        public void ViewOne<T>() where T : Stuff
        {
            
            switch (typeof(T).Name)
            {
                case "Book":
                    {
                        selectionBook[0].Display();
                        break;
                    }
                case "Journal":
                    {
                        selectionJournal[0].Display();
                        break;
                    }
            }
        }

        public void ViewSelection<T>() where T : Stuff
        {
            switch (typeof(T).Name)
            {
                case "Book":              
                    Console.WriteLine("Книги с выбранным именем:*******************");
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
                case "Journal":
                    if (selectionJournal.Count!=0)
                    {              
                        Console.WriteLine("Журналы с выбранным именем:*****************");
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
            System.Console.WriteLine("ВСЯ БИБЛИОТЕКА******************************");
            System.Console.WriteLine("*********************************************");
            System.Console.WriteLine("КНИГИ***************************************");
            if (booksList.Count != 0)
            {
                foreach (Book sb in booksList)
                {
                    sb.Display();
                }
            }
            else
            {
                System.Console.WriteLine("Предложение отсутствует");
                System.Console.WriteLine("********************************************");
            }
            System.Console.WriteLine("ЖУРНАЛЫ*************************************");
            if (journalsList.Count != 0)
            {
                foreach (Journal sj in journalsList)
                {
                    sj.Display();
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
        protected internal readonly int Id; 
        private static int newId=0;

        protected internal string Name;
        protected internal int Quantity;
        protected internal string Publishing;

        protected bool iscorrect = false;

        protected Stuff()
        {
            newId++;
            Id = newId;

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
            System.Console.WriteLine($"ID: {Id}");
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
            System.Console.WriteLine($"ID: {Id}");
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
