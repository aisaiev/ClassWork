using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_Task.Model
{
    public class EntityBase
    {
        private static int counter;

        public int Id { get; set; }

        public bool IsNew { get; set; }

        public EntityBase()
        {
            this.IsNew = true;
            this.Id = counter++;
        }
    }
}
