using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime? Year { get; set; }


        public Student Student { get; set; }
    }
}
