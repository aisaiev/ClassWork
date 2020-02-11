using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Core_Code_First_02_08.Model
{
    public class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string WebSite { get; set; }


        public ICollection<Customer> Customers { get; set; }
    }
}
