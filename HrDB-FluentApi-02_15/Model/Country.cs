using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Country
    {
        public string CountryId { get; set; }

        public string CountryName { get; set; }


        public Region Region { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }
}
