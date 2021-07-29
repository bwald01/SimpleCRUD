﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApi.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Suffix { get; set; }

        public string CompanyName { get; set; }

        public string SalesPerson { get; set; }

        public string EmailAddress { get; set; }

        public string Phone { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
