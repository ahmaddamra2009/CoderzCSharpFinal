using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   public  static class MyExtMethods
    {
        public static string FullName(string n1,string n2)
        {
            return n1 + " "+n2;
        }

        public static bool ThisYear(int currentYear,int inputYear)
        {
            return currentYear == inputYear;
        }
    }
}
