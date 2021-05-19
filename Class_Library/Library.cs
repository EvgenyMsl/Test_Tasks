using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Library<Ttypeofstuff> where Ttypeofstuff : Stuff, IStuff
    {
        private List<Ttypeofstuff> thingList = new List<Ttypeofstuff>();
        private List<Ttypeofstuff> selectionThing = new List<Ttypeofstuff>();

        private readonly string databasepath = "\\";

        public string Databasepath
        {
            get
            {
                return databasepath;
            }
        }

        void Loadtodatabase()
        {

        }

        void Uploadtodatabase()
        {

        }

        public void Add(Ttypeofstuff stuff)
        {
            thingList.Add(stuff);
        }

        public void DeleteSelection()
        {
            selectionThing.Clear();
        }

        public void DeleteAll()
        {
            thingList.Clear();
            System.Console.WriteLine($"{typeof(Ttypeofstuff).Name} is deleted");
        }


        public void Find()
        {
            DeleteSelection();
            System.Console.WriteLine("Enter searching name");
            string name = System.Console.ReadLine();

            foreach (Ttypeofstuff bl in thingList)
                if (bl.Name == name)
                    selectionThing.Add(bl);
            ViewSelection();
        }

        public void Change()
        {
            if (selectionThing.Count > 1)
            {
                ChooseOne();
                Change();
            }
            else
            {
                if (selectionThing.Count != 0)
                {
                    selectionThing[0].Change();
                    selectionThing.Clear();
                }
                else
                {
                    System.Console.WriteLine("This item is missing. Try again? y/n");
                    var answer = System.Console.ReadLine();
                    if (answer == "y")
                    {
                        Find();
                    }
                }
            }
        }

        public void ChooseOne()
        {
            int id = -1;
            bool iscorrect = false;

            while (!iscorrect)
            {
                System.Console.WriteLine("Enter correct id");
                iscorrect = int.TryParse(Console.ReadLine(), out id);
                System.Console.WriteLine("ID: " + id);
            }
            iscorrect = false;

            foreach (Ttypeofstuff b in thingList)
            {
                if (id == b.Id)
                {
                    DeleteSelection();
                    selectionThing.Add(b);
                    System.Console.WriteLine("********************************************");
                    b.Display();
                    break;
                }
            }
        }

        public void ViewOne()
        {
            selectionThing[0].Display();
        }

        public void ViewSelection()
        {
            System.Console.WriteLine("********************************************");
            Console.WriteLine($"{typeof(Ttypeofstuff).Name} with choosen name:");
            if (selectionThing.Count != 0)
            {
                foreach (Ttypeofstuff sb in selectionThing)
                    sb.Display();
            }
            else
            {
                Console.WriteLine($"{typeof(Ttypeofstuff).Name} with choosen name: 0");
            }

        }

        public void ViewAll()
        {
            System.Console.WriteLine("********************************************");
            if (thingList.Count != 0)
            {
                foreach (Ttypeofstuff sb in thingList)
                {
                    sb.Display();
                }
            }
            else
            {
                System.Console.WriteLine("Empty");
                System.Console.WriteLine("********************************************");
            }
        }
    }
}
