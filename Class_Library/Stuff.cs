using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public abstract class Stuff
    {
        protected internal readonly int Id;
        private static int m_newID = 0;

        public string Title { set; get; }
        public int Quantity { set; get; }
        public string Publishing { set; get; }

        protected bool isCorrect;

        protected Stuff()
        {
            m_newID++;
            Id = m_newID;
            Title = "Undefined";
            Quantity = 0;
            Publishing = "Undefined";
        }

    }

}


