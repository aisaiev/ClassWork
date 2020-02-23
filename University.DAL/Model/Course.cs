using System;
using System.Collections.Generic;
using System.Text;

namespace University.DAL.Model
{
    public class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }


        public virtual Department Department { get; set; }

        public virtual List<Student> Students { get; set; }
    }
}
