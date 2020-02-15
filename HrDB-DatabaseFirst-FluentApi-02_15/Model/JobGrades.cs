using System;
using System.Collections.Generic;

namespace HrDB_DatabaseFirst_FluentApi_02_15.Model
{
    public partial class JobGrades
    {
        public string GradeLevel { get; set; }
        public int LowestSal { get; set; }
        public int HighestSal { get; set; }
    }
}
