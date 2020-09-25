using StoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreTest.Handler
{
    public interface ICustomersHandler
    {
        public IEnumerable<Customers> GetAllCustomers();
    }
}
