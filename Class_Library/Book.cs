using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Book : Stuff
    {
        protected internal string author;
        protected internal string genre;
        protected internal int yearOfPublishing=0;
        
        public string Author
        {
            set { author = value; }
            get { return author;  }
        }
        public string Genre 
        {
            set { genre = value; }
            get { return genre;  }
        }
        public int YearOfPublishing 
        {
           set { yearOfPublishing = value; }
           get { return yearOfPublishing;  }
        }

        public Book(string title, int quantity, string publishing, string author="Unknown", string genre = "Unknown", int yearofpublishing = 0) : base(title, quantity, publishing)
        {
            this.title = title;
            this.quantity = quantity;
            this.publishing = publishing;
            this.author = author;
            this.genre = genre;
            this.yearOfPublishing = yearofpublishing;
        }

        private Book()
        {

        }

        
    }
}
