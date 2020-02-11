using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Core_Code_First_02_08.Model
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }
    }
}
