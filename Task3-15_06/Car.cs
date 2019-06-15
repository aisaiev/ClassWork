using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_15_06
{
    public class Car : ICar
    {
        private string name;

        private string year;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        public string Year
        {
            get
            {
                return this.year;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.year = value;
                }
            }
        }

        public Car(string name, string year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}
