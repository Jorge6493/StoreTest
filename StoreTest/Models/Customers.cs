using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreTest.Models
{
    public class Customers
    {
        public int ID { get; set; }
        public string DocumentNumber { get; set; }
        public string FullName { get; set; }
        public decimal CreditLimit { get; set; }
        
        public Byte[] RowVersion { get; set; }
    }
}
