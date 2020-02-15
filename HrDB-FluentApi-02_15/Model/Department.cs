using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public int ManagerId { get; set; }


        public Location Location { get; set; }

        public IEnumerable<JobHistory> JobHistories { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
