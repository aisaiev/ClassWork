using Author_Task.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_Task.Model
{
    public class Book : EntityBase, ICloneable
    {
        public string Title { get; set; }

        public decimal Cost { get; set; }

        public bool IsRead { get; set; }

        public DateTime YearOfPublishing { get; set; }

        public Language Language { get; set; }

        public Book()
        {
            this.YearOfPublishing = DateTime.Now;
        }
    }
}
