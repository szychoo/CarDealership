using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership.DataAcessInterface;
using CarDealership.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarDealershipWebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private readonly ICarDealershipRepository carDealershipRepository;

        public CarsController(ICarDealershipRepository carDealershipRepository)
        {
            this.carDealershipRepository = carDealershipRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return carDealershipRepository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return carDealershipRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
