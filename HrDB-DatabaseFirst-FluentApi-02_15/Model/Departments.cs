using System;
using System.Collections.Generic;

namespace HrDB_DatabaseFirst_FluentApi_02_15.Model
{
    public partial class Departments
    {
        public Departments()
        {
            Employees = new HashSet<Employees>();
            JobHistory = new HashSet<JobHistory>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }
        public int LocationId { get; set; }

        public virtual Locations Location { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<JobHistory> JobHistory { get; set; }
    }
}
