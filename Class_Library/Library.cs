using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class Library<TStuff> where TStuff : Stuff
    {

        private readonly List<TStuff> m_stuffList = new List<TStuff>();
        private readonly List<TStuff> m_selectionStuff = new List<TStuff>();

        private readonly string m_dataBasePath = "\\";

        public string DataBasePath
        {
            get
            {
                return m_dataBasePath;
            }
        }

        public void Add(TStuff stuff)
        {
            m_stuffList.Add(stuff);
        }

        public bool DeleteAll()
        {
            m_stuffList.Clear();
            return true;
        }

        public List<TStuff> FindByName(string title)
        {
            m_selectionStuff.Clear();
            foreach (TStuff thing in m_stuffList)
                if (thing.Title == title)
                    m_selectionStuff.Add(thing);
            return m_selectionStuff.Count!=0 ? m_selectionStuff : null;
        }

        public void DeleteOne(int id)
        {
            m_stuffList.Remove(FindOne(id));
        }

        public TStuff FindOne(int id)
        {
            foreach (TStuff thing in m_stuffList)
            {
                if (id == thing.Id)
                {
                    m_selectionStuff.Clear();
                    return thing;
                }
            }
            return null;
        }

        public List<TStuff> ViewAll()
        {
            List<TStuff> answer = new List<TStuff>();
            if (m_stuffList.Count != 0)
            {
                foreach (TStuff thing in m_stuffList)
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
