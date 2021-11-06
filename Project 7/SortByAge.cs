using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class SortByAge : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee first = x as Employee;
            Employee second = y as Employee;
            if (first.Age == second.Age)
                return 0;
            else if (first.Age > second.Age)
                return 1;
            else
                return -1;
        }
    }
}