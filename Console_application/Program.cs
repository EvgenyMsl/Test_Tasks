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
            bool viewCommand=false;

            Library<Book> lib_book = new Library<Book>();
            Library<Journal> lib_journal = new Library<Journal>();
            List<Book> selectedBooks = new List<Book>();
            List<Journal> selectedJournals = new List<Journal>();
            
            List<Book> outLists = new List<Book>();

            int intBuff;

            string title;
            int quantity;
            string publishing;

            while (!end)
            {
                int id =- 1;
                System.Console.WriteLine("\nEnter a command (\"help\" for help)");
                switch (System.Console.ReadLine())
                {
                    case "-cb":
                        System.Console.WriteLine("\nCreating book");
                        System.Console.WriteLine("title");
                        title = System.Console.ReadLine();
                        System.Console.WriteLine("quantity");
                        int.TryParse(Console.ReadLine(), out intBuff);
                        quantity = intBuff;
                        System.Console.WriteLine("publishing");
                        publishing = System.Console.ReadLine();

                        Book book = new Book(title,quantity,publishing);
                        lib_book.Add(book);
                        break;

                    case "-cj":
                        System.Console.WriteLine("\nCreating journal");
                        System.Console.WriteLine("title");
                        title = System.Console.ReadLine();
                        System.Console.WriteLine("quantity");
                        int.TryParse(Console.ReadLine(), out intBuff);
                        quantity = intBuff;
                        System.Console.WriteLine("publishing");
                        publishing = System.Console.ReadLine();
                        Journal journal = new Journal(title, quantity, publishing);
                        lib_journal.Add(journal);
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
                        selectedBooks.Add(lib_book.FindOne(int.Parse(System.Console.ReadLine())));

                            System.Console.WriteLine("title");
                            selectedBooks[0].Title = Console.ReadLine();

                            System.Console.WriteLine("quantity");
                            int.TryParse(Console.ReadLine(), out intBuff);
                            selectedBooks[0].Quantity = intBuff;

                            System.Console.WriteLine("publishing");
                            selectedBooks[0].Publishing = Console.ReadLine();

                            System.Console.WriteLine("author");
                            selectedBooks[0].Author = Console.ReadLine();

                            System.Console.WriteLine("yearofpublishing");
                            int.TryParse(Console.ReadLine(), out intBuff);
                            selectedBooks[0].YearOfPublishing = intBuff;

                            System.Console.WriteLine("genre");
                            selectedBooks[0].Genre = Console.ReadLine();
                        break;

                    case "-chj":
                        System.Console.WriteLine("\nChanging journal.");
                        selectedJournals.Add(lib_journal.FindOne(int.Parse(System.Console.ReadLine())));

                            System.Console.WriteLine("title");
                            selectedJournals[0].Title = Console.ReadLine();

                            System.Console.WriteLine("quantity");
                            int.TryParse(Console.ReadLine(), out intBuff);
                            selectedJournals[0].Quantity = intBuff;

                            System.Console.WriteLine("publishing");
                            selectedJournals[0].Publishing = Console.ReadLine();

                            System.Console.WriteLine("periodicity");
                            selectedJournals[0].Periodicity = Console.ReadLine();

                            System.Console.WriteLine("yearofrelease");
                            int.TryParse(Console.ReadLine(), out intBuff);
                            selectedJournals[0].Yearofrelease = intBuff; 

                            System.Console.WriteLine("number");
                            selectedJournals[0].Number = int.Parse(Console.ReadLine());
                        break;

                    case "-fb":
                        System.Console.WriteLine("\nFinding book");
                        selectedBooks = lib_book.FindByName(System.Console.ReadLine());
                        break;

                    case "-fj":
                        System.Console.WriteLine("\nFinding journal");
                        selectedJournals=lib_journal.FindByName(System.Console.ReadLine());
                        break;

                    case "-wb":
                        System.Console.WriteLine("\nWiew all books");
                        selectedBooks=lib_book.ViewAll();
                        break;

                    case "-wj":
                        System.Console.WriteLine("\nWiew all journals");
                        selectedJournals=lib_journal.ViewAll();
                        break;

                    case "-wob":
                        System.Console.WriteLine("\nWiew one book");
                        int.TryParse(System.Console.ReadLine(), out id);
                        selectedBooks.Add(lib_book.FindOne(id));
                        break;

                    case "-woj":
                        System.Console.WriteLine("\nWiew one journal");
                        int.TryParse(System.Console.ReadLine(), out id);
                        selectedJournals.Add(lib_journal.FindOne(id));
                        break;

                    case "-dab":
                        viewCommand = true;
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

                if (selectedBooks.Count != 0)
                {
                    foreach (Book selectedBook in selectedBooks)
                    {
                        if (selectedBook != null)
                        {
                            Console.WriteLine("*******************************************");
                            Console.WriteLine("Title " + selectedBook.Title);
                            Console.WriteLine("Quantity " + selectedBook.Quantity);
                            Console.WriteLine("Publishing " + selectedBook.Publishing);
                            Console.WriteLine("Author " + selectedBook.Author);
                            Console.WriteLine("Genre " + selectedBook.Genre);
                            Console.WriteLine("YearOfPublishing " + selectedBook.YearOfPublishing);
                        }
                    }
                }

                
                if (selectedJournals.Count != 0)
                {
                    foreach (Journal selectedJournal in selectedJournals)
                    {
                        if (selectedJournal != null)
                        {
                            Console.WriteLine("*******************************************");
                            Console.WriteLine("Title" + selectedJournal.Title);
                            Console.WriteLine("Quantity" + selectedJournal.Quantity);
                            Console.WriteLine("Publishing" + selectedJournal.Publishing);
                            Console.WriteLine("Periodicity" + selectedJournal.Periodicity);
                            Console.WriteLine("Yearofrelease" + selectedJournal.Yearofrelease);
                            Console.WriteLine("Number" + selectedJournal.Number);
                        }
                    }
                }

                selectedBooks.Clear();
                selectedJournals.Clear();

                
                
                
            }
        }
    }
}
