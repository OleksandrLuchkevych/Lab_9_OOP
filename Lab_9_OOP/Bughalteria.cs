using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_OOP
{
    internal class Bughalteria
    {
        public void ScholarshipPayment(int m)
        {
            if (m >= 88)
              Console.WriteLine("You can have a scholarship!");
            else
                Console.WriteLine("You need to study better to have a scholarship!");

        }
    }
}
