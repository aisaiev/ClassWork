using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class JobHistory
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public Department Department { get; set; }

        public Job Job { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
