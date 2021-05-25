using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Book : Stuff
    {    
        public string Author { set; get; }
        public string Genre { set; get; }
        public int YearOfPublishing { set; get; }

        public Book(string title, int quantity, string publishing, string author = "Unknown", string genre = "Unknown", int yearofpublishing = 0) : this() 
        {
            Title = title;
            Quantity = quantity;
            Publishing = publishing;
            Author = author;
            Genre = genre;
            YearOfPublishing = yearofpublishing;
        }

        private Book()
        {
            Author = "Undefined";
            Genre = "Undefined";
            YearOfPublishing = 0;
        }

        
    }
}
