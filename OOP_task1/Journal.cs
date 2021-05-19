using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_task1
{

    class Journal : Stuff
    {
        public string Periodicity;
        public int Yearofrelease;
        public int Number;

        public Journal()
        {
            System.Console.WriteLine("Enter the publication frequency");
            Periodicity = Console.ReadLine();

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter the year of publication");
                iscorrect = int.TryParse(Console.ReadLine(), out Yearofrelease);
            }
            iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter the release number");
                iscorrect = int.TryParse(Console.ReadLine(), out Number);
            }
            iscorrect = false;
        }

        override public void Display()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Title : {Name}");
            System.Console.WriteLine($"Quantity: {Quantity}");
            System.Console.WriteLine($"Publishing: {Publishing}");
            System.Console.WriteLine($"Periodicity: {Periodicity}");
            System.Console.WriteLine($"Year of release: {Yearofrelease}");
            System.Console.WriteLine($"Number: {Number}");
            System.Console.WriteLine("********************************************");

        }

        public override void Change()
        {
            string strAnswer;
            System.Console.WriteLine("Enter new title or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Name = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct quantity or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Quantity) : true;

            }
            iscorrect = false;

            System.Console.WriteLine("Enter new publishing or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Publishing = strAnswer;

            System.Console.WriteLine("Enter new year of release or press Enter");
            strAnswer = Console.ReadLine();
            if (strAnswer != "")
                Periodicity = strAnswer;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct year of release by number or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Yearofrelease) : true;
            }
            iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter new correct release number or press Enter");
                strAnswer = Console.ReadLine();
                iscorrect = (strAnswer != "") ? int.TryParse(strAnswer, out Quantity) : true;
            }
        }
    }
}
