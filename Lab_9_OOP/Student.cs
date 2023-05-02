using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_9_OOP
{

    internal class Student
    {
        public event MyDel MarkChange;
        public string name;
        List<int> marks = new();

        public void AddMark(int m)
        {
            if (MarkChange != null)
            {
                MarkChange(m);
            }

        }
    }
}
