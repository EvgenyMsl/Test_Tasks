using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Journal : Stuff
    {

        public string Periodicity { set; get; }
        public int Yearofrelease { set; get; }
        public int Number { set; get; }

        public Journal(string title, int quantity,string publishing, string periodicity = "Unknown", int yearofrelease=0, int number=0) : base(title,quantity,publishing)
        {
            Title = title;
            Quantity = quantity;
            Publishing = publishing;
            Periodicity = periodicity;
            Yearofrelease = yearofrelease;
            Number = number;
        }

        private Journal() : base()//запретим пользоваться конструктором по умолчанию
        {

        }


    }
}
