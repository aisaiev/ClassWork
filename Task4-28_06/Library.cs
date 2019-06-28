using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_28_06
{
    public class Library
    {
        public string GiveBook()
        {
            Random rnd = new Random();
            string book = $"Book_{rnd.Next(1, 101)}";
            Console.WriteLine($"Student took the book '{book}'");
            return book;
        }

        public void GetBook(string book)
        {
            Console.WriteLine($"'{book}' returned to the library");
        }
    }
}
