﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
