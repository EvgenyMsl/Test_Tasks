using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Library<Ttypeofstuff> where Ttypeofstuff : Stuff, IStuff
    {
        List<string> info = new List<string>();
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

        void LoadToDatabase()
        {

        }

        void UploadToDatabase()
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

        public bool DeleteAll()
        {
            thingList.Clear();
            return true;
        }


        public void Find(string title)
        {
            DeleteSelection();
            foreach (Ttypeofstuff bl in thingList)
                if (bl.title == title)
                    selectionThing.Add(bl);
            ViewSelection();
        }

        public bool Change(string[] changeInfo)
        {
            if (selectionThing.Count != 0)
            {
                selectionThing[0].Change(changeInfo);
                selectionThing.Clear();
                return true;
            }
            else
                return false;
        }

        public void DeleteOne(int id)
        {
            ChooseOne(id);
            thingList.Remove(selectionThing[0]);
        }

        public List<string> ChooseOne(int id)
        {
            foreach (Ttypeofstuff b in thingList)
            {
                if (id == b.Id)
                {
                    DeleteSelection();
                    selectionThing.Add(b);
                    return b.Display();
                }
            }
            return null;
        }

        public List<string> ViewOne()
        {
            if (selectionThing.Count != 0)
            {
                if (selectionThing[0].title != "")
                    return selectionThing[0].Display();
                else
                    return null;
            }
            return null;
        }

        public List<Ttypeofstuff> ViewSelection()
        {
            List<Ttypeofstuff> listOfAnswers = new List<Ttypeofstuff>();
            if (selectionThing.Count != 0)
                foreach (Ttypeofstuff sb in selectionThing)
                    if (selectionThing[0].title != "")
                        listOfAnswers.Add(sb);
            return listOfAnswers;

        }

        public bool ViewAll(List<List<String>> answer)
        {
            if (thingList.Count != 0)
            {
                foreach (Ttypeofstuff sb in thingList)
                {
                    answer.Add(sb.Display());
                }
                return true;
            }
            else
                return false;
        }
    }
}
