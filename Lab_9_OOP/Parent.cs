using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_OOP
{
    internal class Parent
    {
        public void OnMarkChange(int m)
        {
            Console.WriteLine($"Mark of your child: {m}");
        }
    }
}
