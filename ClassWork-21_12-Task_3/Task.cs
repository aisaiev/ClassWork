using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_21_12_Task_3
{
    public class Task
    {
        public string TaskName { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }

        public Task(string taskName, string description, int priority)
        {
            this.TaskName = taskName;
            this.Description = description;
            this.Priority = priority;
        }
    }
}
