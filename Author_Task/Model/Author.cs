using Author_Task.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_Task.Model
{
    public class Author : EntityBase, ICloneable
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PlaceOfBirth { get; set; }

        public DateTime BirthDate { get; set; }

        public Country Country { get; set; }

        public Language Language { get; set; }

        public ObservableCollection<Book> Books { get; set; }

        public Author()
        {
            this.BirthDate = DateTime.Now;
            this.Books = new ObservableCollection<Book>();
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
