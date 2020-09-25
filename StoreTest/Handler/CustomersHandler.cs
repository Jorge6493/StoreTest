using Microsoft.EntityFrameworkCore;
using StoreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreTest.Handler
{
    public class CustomersHandler : ICustomersHandler
    {
        private readonly ApplicationDBContext _DBContext;

        public CustomersHandler(ApplicationDBContext DBContext)
        {
            _DBContext = DBContext;
        }
        public IEnumerable<Customers> Customers { get; set; }

        public IEnumerable<Customers> GetAllCustomers()
        {
            return Customers = (IEnumerable<Customers>)_DBContext.Customers.ToList();
            //return Enumerable.Range(1,5).Select(index => new Customers
            //{
            //    FullName = Customers.in
            //})
        }
    }

}
