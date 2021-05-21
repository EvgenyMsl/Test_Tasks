using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Book : Stuff, IStuff
    {
        protected internal string author;
        protected internal string genre;
        protected internal string yearofpublishing;

        public Book(string title, string quantity, string publishing = "Unknown", string author = "Unknown", string genre = "Unknown", string yearofpublishing="Unknown") : base(title,quantity,publishing)
        {
            this.author = author;
            this.genre = genre;
            this.yearofpublishing = yearofpublishing;
        }

        public List<string> Display()
        {
            List<string> answer = new List<string>();
            if (title != "")
            {
                answer.Add(Id.ToString());
                answer.Add(title);
                answer.Add(quantity.ToString());
                answer.Add(publishing);
                answer.Add(author);
                answer.Add(genre);
                answer.Add(yearofpublishing.ToString());
            }
            return answer;
        }

        public void Change(string[] changeInfo)
        {
            this.title =            changeInfo[0];
            this.quantity =         changeInfo[1];
            this.publishing =       changeInfo[2];
            this.author =           changeInfo[3];
            this.genre =            changeInfo[4];
            this.yearofpublishing = changeInfo[5];
        }
    }
}
