using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreTest.Handler;
using StoreTest.Models;

namespace StoreTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        //private readonly ApplicationDBContext _DBContext;
        private readonly ICustomersHandler _CustomersHandler;

        public CustomersController(ICustomersHandler CustomersHandler)
        {
            //_DBContext = DBContext;
            _CustomersHandler = CustomersHandler;
        }

        public IEnumerable<Customers> Customers { get; set; }

        [HttpGet]
        public void GetAllCustomersRequest()
        {
            _CustomersHandler.GetAllCustomers();
            //Customers = await _DBContext.Customers.ToListAsync();
        }

        //[HttpGet]
        //public async Task GetCustomerByIDRequest(int ID)
        //{
        //    Customers = await _DBContext.Customers.ToListAsync();
        //}


        //[HttpGet]
        //public IEnumerable<Customer> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
