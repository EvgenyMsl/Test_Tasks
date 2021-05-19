using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public abstract class Stuff
    {
        protected internal readonly int Id;
        private static int newId = 0;
        protected internal string Name;
        protected internal int Quantity;
        protected internal string Publishing;

        protected bool iscorrect = false;

        protected Stuff()
        {
            newId++;
            Id = newId;

            System.Console.WriteLine("********************************************");
            System.Console.WriteLine("Enter the title");
            Name = Console.ReadLine();

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter correct quantity");
                iscorrect = int.TryParse(Console.ReadLine(), out Quantity);
            }
            iscorrect = false;

            System.Console.WriteLine("Enter Publishing");
            Publishing = Console.ReadLine();
        }

    }

}
