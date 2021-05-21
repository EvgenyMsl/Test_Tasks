using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public interface IStuff
    {
        abstract public List<string> Display();
        abstract public void Change(List<string> a);
    }
}
