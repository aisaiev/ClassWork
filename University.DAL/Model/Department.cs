using System;
using System.Collections.Generic;
using System.Text;

namespace University.DAL.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; }


        public virtual List<Course> Courses { get; set; }
    }
}
