using System;
using System.Text;
using Class_Library;
using System.Collections.Generic;

namespace Console_application
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;

            Library<Book> lib_book = new Library<Book>();
            Library<Journal> lib_journal = new Library<Journal>();

            List<String> outList = new List<string>();
            List<List<String>> outLists = new List<List<String>>();
            List<String> changeInfo = new List<String>();

            string title = "";
            string quantity = "";
            string publishing = "";
            string author = "";
            string genre = "";
            string yearofpublishing = "";

            while (!end)
            {
                int id=-1;
                System.Console.WriteLine("\nEnter a command (\"help\" for help)");
                switch (System.Console.ReadLine())
                {
                    case "-cb":
                        System.Console.WriteLine("\nCreating book");
                        Book book = new Book(System.Console.ReadLine(), "10");
                        lib_book.Add(book);
                        break;

                    case "-cj":
                        System.Console.WriteLine("\nCreating journal");
                        Journal journal = new Journal(System.Console.ReadLine(), "1");
                        lib_journal.Add(journal);
                        break;

                    case "-dbs":
                        System.Console.WriteLine("\nDeletimg all books with definite name");
                        lib_book.Find(System.Console.ReadLine());
                        lib_book.DeleteSelection();
                        break;

                    case "-djs":
                        System.Console.WriteLine("\nDeleting all journals with definite name");
                        lib_journal.Find(System.Console.ReadLine());
                        lib_journal.DeleteSelection();
                        break;

                    case "-dob":
                        System.Console.WriteLine("\nDeleting one book with definite name:");
                        int.TryParse(System.Console.ReadLine(), out id);
                        lib_book.DeleteOne(id);
                        break;

                    case "-doj":
                        System.Console.WriteLine("\nDeleting one journal with definite name:");
                        int.TryParse(System.Console.ReadLine(), out id);
                        lib_journal.DeleteOne(id);
                        break;

                    case "-chb":
                        System.Console.WriteLine("\nChanging book");
                        lib_book.Find(System.Console.ReadLine());
                        
                        title =            Console.ReadLine();
                        quantity =         Console.ReadLine();
                        publishing =       Console.ReadLine();
                        author =           Console.ReadLine();
                        genre =            Console.ReadLine();
                        yearofpublishing = Console.ReadLine();

                        changeInfo.Add(title);
                        changeInfo.Add(quantity);
                        changeInfo.Add(publishing);
                        changeInfo.Add(author);
                        changeInfo.Add(genre);
                        changeInfo.Add(yearofpublishing);
                        lib_book.Change(changeInfo);

                        outList = lib_book.ViewOne();
                        break;

                    case "-chj":
                        System.Console.WriteLine("\nChanging journal");
                        lib_journal.Find(System.Console.ReadLine());
                        
                        title = Console.ReadLine();
                        quantity = Console.ReadLine();
                        publishing = Console.ReadLine();
                        author = Console.ReadLine();
                        genre = Console.ReadLine();
                        yearofpublishing = Console.ReadLine();

                        changeInfo.Add(title);
                        changeInfo.Add(quantity);
                        changeInfo.Add(publishing);
                        changeInfo.Add(author);
                        changeInfo.Add(genre);
                        changeInfo.Add(yearofpublishing);
                        lib_book.Change(changeInfo);

                        outList = lib_journal.ViewOne();
                        break;

                    case "-fb":
                        System.Console.WriteLine("\nFinding book");
                        lib_book.Find(System.Console.ReadLine());
                        outList=lib_book.ViewOne();
                        break;

                    case "-fj":
                        System.Console.WriteLine("\nFinding journal");
                        lib_journal.Find(System.Console.ReadLine());
                        outList = lib_journal.ViewOne();
                        break;

                    case "-wb":
                        System.Console.WriteLine("\nWiew all books");
                        lib_book.ViewAll(outLists);
                        break;

                    case "-wj":
                        System.Console.WriteLine("\nWiew all journals");
                        lib_journal.ViewAll(outLists);
                        break;

                    case "-wob":
                        System.Console.WriteLine("\nWiew one book");
                        lib_book.Find(System.Console.ReadLine());
                        int.TryParse(System.Console.ReadLine(), out id);
                        lib_book.ChooseOne(id);
                        lib_book.ViewOne();
                        break;

                    case "-woj":
                        System.Console.WriteLine("\nWiew one journal");
                        lib_journal.Find(System.Console.ReadLine());
                        int.TryParse(System.Console.ReadLine(), out id);
                        lib_journal.ChooseOne(id);
                        lib_journal.ViewOne();
                        break;

                    case "-dab":
                        System.Console.WriteLine("\nDeleting all books");
                        lib_book.DeleteAll();
                        break;

                    case "-daj":
                        System.Console.WriteLine("\nDeleting all journals");
                        lib_journal.DeleteAll();
                        break;

                    case "-help":

                        System.Console.WriteLine("\nCreate book \"-cb\"");
                        System.Console.WriteLine("Create journal \"-cj\"");
                        System.Console.WriteLine("Delete one book with definite name \"-dob\"");
                        System.Console.WriteLine("Delete one journal with definite name \"-doj\"");
                        System.Console.WriteLine("Delete all book with definite name \"-dbs\"");
                        System.Console.WriteLine("Delete all journal with definite name \"-djs\"");
                        System.Console.WriteLine("Change book \"-chb\"");
                        System.Console.WriteLine("Change journal \"-chj\"");
                        System.Console.WriteLine("Find book \"-fb\"");
                        System.Console.WriteLine("Find journal \"-fj\"");
                        System.Console.WriteLine("Wiew all books\"-wb\"");
                        System.Console.WriteLine("Wiew all journals \"-wj\"");
                        System.Console.WriteLine("Wiew one books\"-wob\"");
                        System.Console.WriteLine("Wiew one journals \"-woj\"");
                        System.Console.WriteLine("Delete all books \"-dab\"");
                        System.Console.WriteLine("Delete all journals \"-daj\"");


                        System.Console.WriteLine("end of work \"-end\"");

                        break;
                    case "end":
                        end = true;
                        break;
                }

                /*////////////////////////////////////////
                
                System.Console.WriteLine("\nCreating book");
                Book book = new Book("Война и мир", 10);
                lib_book.Add(book);

                System.Console.WriteLine("\nCreating book");
                book = new Book("Библия", 10);
                lib_book.Add(book);

                System.Console.WriteLine("\nCreating book");
                book = new Book("Библия", 10);
                lib_book.Add(book);

                lib_book.Find("Библия");
                outList=lib_book.ViewOne();
                lib_book.ViewAll(outLists);

                lib_book.DeleteOne(3);
                lib_book.ViewAll(outLists);

                */////////////////////////////////////////

                Console.WriteLine("*******************************************"); 
                
                for (int i = 0; i < outList.Count; i++)
                {
                    Console.WriteLine(outList[i]);
                }
 
                Console.WriteLine("*******************************************");
   
                foreach (List<string> oL in outLists)
                {
                    Console.WriteLine(oL[0]);
                    Console.WriteLine(oL[1]);
                    Console.WriteLine(oL[2]);
                    Console.WriteLine(oL[3]);
                    Console.WriteLine(oL[4]);
                    Console.WriteLine(oL[5]);
                    Console.WriteLine(oL[6]);
                }

                Console.WriteLine("*******************************************");

                outList.Clear();
                outLists.Clear();
            }
        }
    }
}
