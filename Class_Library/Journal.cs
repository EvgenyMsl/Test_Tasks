using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Journal : Stuff, IStuff
    {
        public string periodicity;
        public string yearofrelease;
        public string number;

        public Journal(string title, string quantity, string publishing="unknown", string periodicity="unknown", string yearofrelease=0, string number=0) : base(title,quantity,publishing)
        {
            this.title = title;
            this.quantity = quantity;
            this.publishing = publishing;
            this.periodicity = periodicity;
            this.yearofrelease = yearofrelease;
            this.number = number;
        }


        public List<string> Display()
        {
            List<String> answer = new List<string>();
            if (title != "")
            {
                answer.Add(Id.ToString());
                answer.Add(title);
                answer.Add(quantity.ToString());
                answer.Add(publishing);
                answer.Add(periodicity);
                answer.Add(yearofrelease.ToString());
                answer.Add(number.ToString());
            }
            return answer; 
        }

        public void Change(List<string> changeInfo)
        {
            this.title = changeInfo[0];
            this.quantity = changeInfo[1];
            this.publishing = changeInfo[2];
            this.periodicity = changeInfo[3];
            this.yearofrelease = changeInfo[4];
            this.number = changeInfo[5];
        }
    }
}
