using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Location
    {
        public int LocationId { get; set; }

        public string StreetAddress { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string StateProvince { get; set; }


        public Country Country { get; set; }

        public IEnumerable<Department> Departments { get; set; }
    }
}
