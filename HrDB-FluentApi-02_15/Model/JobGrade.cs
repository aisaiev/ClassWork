using System;
using System.Collections.Generic;
using System.Text;

namespace HrDB_FluentApi_02_15.Model
{
    public class JobGrade
    {
        public string GradeLevel { get; set; }

        public decimal LowestSal { get; set; }

        public decimal HighestSal { get; set; }
    }
}
