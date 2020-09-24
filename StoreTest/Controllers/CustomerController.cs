using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreTest.Models;

namespace StoreTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDBContext _dBContext;

        public CustomersController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public IEnumerable<Customers> Customers { get; set; }

        [HttpGet]
        public async Task Get()
        {
            Customers = await _dBContext.Customers.ToListAsync();
        }


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
