using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public abstract class Stuff
    {
        protected internal readonly int Id;
        private static int newId = 0;
        protected internal string title;
        protected internal string quantity;
        protected internal string publishing;

        protected bool iscorrect;

        protected Stuff(string title, string quantity, string publishing="Unknown")
        {
            newId++;
            Id = newId;
            this.title = title;
            this.quantity = quantity;
            this.publishing = publishing;
        }

    }

}
