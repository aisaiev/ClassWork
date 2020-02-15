using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Region
    {
        public int RegionId { get; set; }

        public string RegionName { get; set; }


        public IEnumerable<Country> Countries { get; set; }
    }
}
