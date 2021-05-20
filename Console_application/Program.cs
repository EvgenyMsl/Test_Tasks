﻿using System;
using Class_Library;

namespace Console_application
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
                switch (System.Console.ReadLine())
                {
                    case "-cb":
                        System.Console.WriteLine("\nCreating book");
                        Book book = new Book();
                        lib_book.Add(book);
                        break;
                    case "-cj":
                        System.Console.WriteLine("\nCreating journal");
                        Journal journal = new Journal();
                        lib_journal.Add(journal);
                        break;
                    case "-dbs":
                        System.Console.WriteLine("\nDeletimg all books with definite name");
                        lib_book.Find();
                        lib_book.DeleteSelection();
                        break;
                    case "-djs":
                        System.Console.WriteLine("\nDeleting all journals with definite name");
                        lib_journal.Find();
                        lib_journal.DeleteSelection();
                        break;
                    case "-dob":
                        System.Console.WriteLine("\nDeleting one book with definite name:");
                        lib_book.DeleteOne();
                        break;
                    case "-doj":
                        System.Console.WriteLine("\nDeleting one journal with definite name:");
                        lib_journal.DeleteOne();
                        break;
                    case "-chb":
                        System.Console.WriteLine("\nChanging book");
                        lib_book.Find();
                        lib_book.Change();
                        break;
                    case "-chj":
                        System.Console.WriteLine("\nChanging journal");
                        lib_journal.Find();
                        lib_journal.Change();
                        break;
                    case "-fb":
                        System.Console.WriteLine("\nDinding book");
                        lib_book.Find();
                        break;
                    case "-fj":
                        System.Console.WriteLine("\nFinding journal");
                        lib_journal.Find();
                        break;
                    case "-wb":
                        System.Console.WriteLine("\nWiew all books");
                        lib_book.ViewAll();
                        break;
                    case "-wj":
                        System.Console.WriteLine("\nWiew all journals");
                        lib_journal.ViewAll();
                        break;

                    case "-wob":
                        System.Console.WriteLine("\nWiew one books");
                        lib_book.Find();
                        lib_book.ChooseOne();
                        lib_book.ViewOne();
                        break;
                    case "-woj":
                        System.Console.WriteLine("\nWiew one journals");
                        lib_journal.Find();
                        lib_journal.ChooseOne();
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
            }
        }
    }
}
