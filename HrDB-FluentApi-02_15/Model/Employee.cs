using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public int CommissionPct { get; set; }

        public int ManagerId { get; set; }


        public Department Department { get; set; }

        public Job Job { get; set; }

        public IEnumerable<JobHistory> JobHistories { get; set; }
    }
}
