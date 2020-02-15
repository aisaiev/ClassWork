using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Job
    {
        public string JobId { get; set; }

        public string JobTitle { get; set; }

        public decimal MinSalary { get; set; }

        public decimal MaxSalary { get; set; }


        public IEnumerable<Employee> Employees { get; set; }
        public IEnumerable<JobHistory> JobHistories { get; set; }
    }
}
