using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Library<Tstuff> where Tstuff : Stuff
    {

        private readonly List<Tstuff> stuffList = new List<Tstuff>();
        private readonly List<Tstuff> selectionStuff = new List<Tstuff>();

        private readonly string dataBasePath = "\\";

        public string DataBasePath
        {
            get
            {
                return dataBasePath;
            }
        }

        public void Add(Tstuff stuff)
        {
            stuffList.Add(stuff);
        }

        public bool DeleteAll()
        {
            stuffList.Clear();
            return true;
        }

        public List<Tstuff> FindByName(string title)
        {
            selectionStuff.Clear();
            foreach (Tstuff thing in stuffList)
                if (thing.title == title)
                    selectionStuff.Add(thing);
            return selectionStuff.Count!=0 ? selectionStuff : null;
        }

        public void DeleteOne(int id)
        {
            stuffList.Remove(FindOne(id));
        }

        public Tstuff FindOne(int id)
        {
            foreach (Tstuff thing in stuffList)
            {
                if (id == thing.Id)
                {
                    selectionStuff.Clear();
                    return thing;
                }
            }
            return null;
        }

        public List<Tstuff> ViewAll()
        {
            List<Tstuff> answer = new List<Tstuff>();
            if (stuffList.Count != 0)
            {
                foreach (Tstuff thing in stuffList)
                {
                    answer.Add(thing);
                }
                return answer;
            }
            else
                return null;
        }
    }
}
