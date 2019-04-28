using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public static class Task6
    {
        public static void Longest()
        {
            string a = "xyaabbbccccdefww";
            string b = "xxxxyyyyabklmopq";

            IEnumerable<char> c = a.Distinct();
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
