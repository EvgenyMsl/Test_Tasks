using System;
using System.Collections.Generic;

namespace OOP_task1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool end = false;
            Library<Book> lib_book = new Library<Book>();
            Library<Journal> lib_journal = new Library<Journal>();

            while (!end)
            {
                System.Console.WriteLine("\nEnter a command (\"help\" for help)");
                switch(System.Console.ReadLine())
                {
                    case "-cb":
                        System.Console.WriteLine("\ncreating book");
                        Book book = new Book();
                        lib_book.Add(book);
                    break;
                    case "-cj":
                        System.Console.WriteLine("\ncreating journal");
                        Journal journal = new Journal();
                        lib_journal.Add(journal);
                        break;
                    case "-dbs":
                        System.Console.WriteLine("\ndeletimg all books with definite name");
                        lib_book.Find();
                        lib_book.DeleteSelection();
                        break;
                    case "-djs":
                        System.Console.WriteLine("\ndeleting all journals with definite name");
                        lib_journal.Find();
                        lib_journal.DeleteSelection();
                        break;
                    case "-dob":
                        System.Console.WriteLine("\ndeleting one book with definite name:");
                        lib_book.Find();
                        lib_book.ChooseOne();
                        lib_book.DeleteSelection();
                        break;
                    case "-doj":
                        System.Console.WriteLine("\ndeleting one journal with definite name:");
                        lib_journal.Find();
                        lib_journal.ChooseOne();
                        lib_journal.DeleteSelection();
                        break;
                    case "-chb":
                        System.Console.WriteLine("\nchanging book");
                        lib_book.Find();
                        lib_book.Change();
                        break;
                    case "-chj":
                        System.Console.WriteLine("\nchanging journal");
                        lib_journal.Find();
                        lib_journal.Change();
                        break;
                    case "-fb":
                        System.Console.WriteLine("\nfinding book");
                        lib_book.Find();
                        break;
                    case "-fj":
                        System.Console.WriteLine("\nfinding journal");
                        lib_journal.Find();
                        break;
                    case "-wb":
                        System.Console.WriteLine("\nwiew all books");
                        lib_book.ViewAll();
                        break;
                    case "-wj":
                        System.Console.WriteLine("\nwiew all journals");
                        lib_journal.ViewAll();
                        break;

                    case "-wob":
                        System.Console.WriteLine("\nwiew one books");
                        lib_book.Find();
                        lib_book.ChooseOne();
                        lib_book.ViewOne();
                        break;
                    case "-woj":
                        System.Console.WriteLine("\nwiew one journals");
                        lib_journal.Find();
                        lib_journal.ChooseOne();
                        lib_journal.ViewOne();
                        break;
                    case "-dab":
                        System.Console.WriteLine("\ndeleting all books");
                        lib_book.DeleteAll();
                        break;
                    case "-daj":
                        System.Console.WriteLine("\ndeleting all journals");
                        lib_journal.DeleteAll();
                        break;
                    case "-help":

                        System.Console.WriteLine("\ncreate book \"-cb\"");
                        System.Console.WriteLine("create journal \"-cj\"");
                        System.Console.WriteLine("delete one book with definite name \"-dob\"");
                        System.Console.WriteLine("delete one journal with definite name \"-doj\"");
                        System.Console.WriteLine("delete all book with definite name \"-dbs\"");
                        System.Console.WriteLine("delete all journal with definite name \"-djs\"");
                        System.Console.WriteLine("change book \"-chb\"");
                        System.Console.WriteLine("change journal \"-chj\"");
                        System.Console.WriteLine("find book \"-fb\"");
                        System.Console.WriteLine("find journal \"-fj\"");
                        System.Console.WriteLine("wiew all books\"-wb\"");
                        System.Console.WriteLine("wiew all journals \"-wj\"");
                        System.Console.WriteLine("wiew one books\"-wob\"");
                        System.Console.WriteLine("wiew one journals \"-woj\"");
                        System.Console.WriteLine("delete all books \"-dab\"");
                        System.Console.WriteLine("delete all journals \"-daj\"");


                        System.Console.WriteLine("end of work \"-end\"");

                        break;
                    case "end":
                        end = true;
                        break;
                }
            }
        }
    }
    class Library<Ttypeofstuff> where Ttypeofstuff: Stuff
    {
        private List<Ttypeofstuff> thingList = new List<Ttypeofstuff>();
        private List<Ttypeofstuff> selectionThing = new List<Ttypeofstuff>();

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

        public void Add(Ttypeofstuff stuff)
        {
            thingList.Add(stuff);
        }

        public void DeleteSelection()
        {
            selectionThing.Clear();
        }

        public void DeleteAll()
        {
            thingList.Clear();
            System.Console.WriteLine($"{typeof(Ttypeofstuff).Name} is deleted");
        }


        public void Find()
        {
            DeleteSelection();
            System.Console.WriteLine("Enter searching name");
            string name = System.Console.ReadLine();

            foreach (Ttypeofstuff bl in thingList)
                if (bl.Name == name)
                    selectionThing.Add(bl);
                    ViewSelection();
        }

        public void Change()
        {
            if (selectionThing.Count > 1)
            {
                ChooseOne();
                Change();
            }
            else
            {
                if (selectionThing.Count != 0)
                {
                    selectionThing[0].Change();
                    selectionThing.Clear();
                }
                else
                {
                    System.Console.WriteLine("This item is missing. Try again? y/n");
                    var answer = System.Console.ReadLine();
                    if (answer == "y")
                    {
                        Find();
                    }
                }
            }
        }

        public void ChooseOne()
        {
            int id=-1;
            bool iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter correct id");
                iscorrect = int.TryParse(Console.ReadLine(), out id);
                System.Console.WriteLine("ID: " + id);
            }
            iscorrect = false;

            foreach (Ttypeofstuff b in thingList)
            {
                if (id == b.Id)
                {
                    DeleteSelection();
                    selectionThing.Add(b);
                    System.Console.WriteLine("********************************************");
                    b.Display();
                    break;
                }
            }
        }

        public void ViewOne()
        {
           selectionThing[0].Display();
        }

        public void ViewSelection()
        {
            System.Console.WriteLine("********************************************");
            Console.WriteLine($"{typeof(Ttypeofstuff).Name} with choosen name:");
            if (selectionThing.Count != 0)
            {
                foreach (Ttypeofstuff sb in selectionThing)
                sb.Display();
            }
            else
            {
                Console.WriteLine($"{typeof(Ttypeofstuff).Name} with choosen name: 0");
            }

        }

        public void ViewAll()
        {
            System.Console.WriteLine("********************************************");
            if (thingList.Count != 0)
            {
                foreach(Ttypeofstuff sb in thingList)
                {
                    sb.Display();
                }
            }
            else
            {
                System.Console.WriteLine("Empty");
                System.Console.WriteLine("********************************************");
            }
        }
    }          

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

            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("Enter the title");
            Name = Console.ReadLine();

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter correct quantity");
                iscorrect=int.TryParse(Console.ReadLine(), out Quantity);
            }
            iscorrect = false;
            
            System.Console.WriteLine("Enter Publishing");
            Publishing = Console.ReadLine();
        }
        abstract public void Display();
        abstract public void Change();
    }

    class Book: Stuff
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
        override public void Display()
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

        public override void Change()
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

    class Journal: Stuff
    {
        public string Periodicity;
        public int Yearofrelease;
        public int Number;

        public Journal()
        {
            System.Console.WriteLine("Enter the publication frequency");
            Periodicity = Console.ReadLine();
            
            while (!iscorrect)
            {
                System.Console.WriteLine("Enter the year of publication");
                iscorrect = int.TryParse(Console.ReadLine(), out Yearofrelease);
            }
            iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter the release number");
                iscorrect = int.TryParse(Console.ReadLine(), out Number);
            }
            iscorrect = false;
        }

        override public void Display()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Title : {Name}");
            System.Console.WriteLine($"Quantity: {Quantity}");
            System.Console.WriteLine($"Publishing: {Publishing}");
            System.Console.WriteLine($"Periodicity: {Periodicity}");
            System.Console.WriteLine($"Year of release: {Yearofrelease}");
            System.Console.WriteLine($"Number: {Number}");
            System.Console.WriteLine("********************************************");

        }

        public override void Change()
        {
            string strAnswer;
            System.Console.WriteLine("Enter new title or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Name = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct quantity or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Quantity) : true;

            }
            iscorrect = false;

            System.Console.WriteLine("Enter new publishing or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Publishing = strAnswer;

            System.Console.WriteLine("Enter new year of release or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Periodicity = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct year of release by number or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Yearofrelease) : true;
            }
            iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct release number or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Quantity) : true;
            }
        }
    }

}
