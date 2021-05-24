using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Journal : Stuff
    {
        private string periodicity;
        private int yearofrelease;
        private int number;

        public string Periodicity
        {
            set { periodicity = value; }
            get { return periodicity; }
        }
        public int Yearofrelease
        {
            set { yearofrelease = value;}
            get { return yearofrelease; }
        }
        public int Number 
        {
            set { number = value; }
            get { return number; }
        }

        public Journal(string title, int quantity,string publishing, string periodicity = "Unknown", int yearofrelease=0, int number=0) : base(title,quantity,publishing)
        {
            this.title = title;
            this.quantity = quantity;
            this.publishing = publishing;
            this.periodicity = periodicity;
            this.yearofrelease = yearofrelease;
            this.number = number;
        }

        public Journal(string title) : base()
        {
            this.title = title;
        }

        private Journal() : base()//запретим пользоваться конструктором по умолчанию
        {

        }


    }
}
