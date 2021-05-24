using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public abstract class Stuff
    {
        protected internal readonly int Id;
        private static int newID = 0;
        protected internal string title;
        protected internal int quantity;
        protected internal string publishing;

        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
        public string Publishing
        {
            set { publishing = value; }
            get { return publishing; }
        }

        protected bool isCorrect;

        protected Stuff(string title, int quantity, string publishing)
        {
            newID++;
            Id = newID;
            this.title = title;
            this.quantity = quantity;
            this.publishing = publishing;
        }

        private protected Stuff()
        {

        }
    }

}
