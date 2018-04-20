using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership.DataAccessEF;
using CarDealership.DataAcessInterface;
using CarDealership.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarDealershipWebApiCore.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private readonly CarDealershipDbContext _carDealershipDbContext;

        public CarsController(CarDealershipDbContext carDealershipDbContext)
        {
            _carDealershipDbContext = carDealershipDbContext;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _carDealershipDbContext.Cars.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}", Name ="GetCar")]
        public IActionResult Get(int id)
        {
            var car = _carDealershipDbContext.Cars.FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound();
            }
            return new ObjectResult(car);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            if(car == null)
            {
                return BadRequest();
            }

            _carDealershipDbContext.Cars.Add(car);
            _carDealershipDbContext.SaveChanges();

            return CreatedAtRoute("GetCars", new { id = car.Id }, car);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Car car)
        {
            if(car == null || id != car.Id)
            {
                return BadRequest();
            }

            var _car = _carDealershipDbContext.Cars.FirstOrDefault(c => c.Id == id);
            if(_car == null)
            {
                return NotFound();
            }

            _car.Color = car.Color;
            _car.EngineSize = car.EngineSize;
            _car.HorsePower = car.HorsePower;
            _car.Make = car.Make;
            _car.Model = car.Model;
            _car.ProductionYear = car.ProductionYear;

            _carDealershipDbContext.Cars.Update(_car);
            _carDealershipDbContext.SaveChanges();

            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var car = _carDealershipDbContext.Cars.FirstOrDefault(c => c.Id == id);
            if(car == null)
            {
                return NotFound();
            }
            _carDealershipDbContext.Cars.Remove(car);
            _carDealershipDbContext.SaveChanges();

            return new NoContentResult();
        }
    }
}
