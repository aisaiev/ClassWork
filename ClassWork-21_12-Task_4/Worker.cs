using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_21_12_Task_4
{
    public class Worker
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public DateTime HireDate { get; set; }

        public bool IsManager { get; set; }

        public Worker(int id, string name, string department, DateTime hireDate, bool isManager)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.HireDate = hireDate;
            this.IsManager = isManager;
        }
    }
}
