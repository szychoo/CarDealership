using CarDealership.DataAcessInterface;
using CarDealership.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealership.DataAccessEF
{
    public class CarDealershipRepository : ICarDealershipRepository
    {
        private readonly CarDealershipDbContext _carDealershipDbContext;

        public CarDealershipRepository(CarDealershipDbContext carDealershipDbContext)
        {
            _carDealershipDbContext = carDealershipDbContext;
        }

        public Car GetById(int id)
        {
            return _carDealershipDbContext.Cars.FirstOrDefault(car => car.Id == id);
        }

        public IQueryable<Car> GetAll()
        {
            return _carDealershipDbContext.Cars;
        }
    }
}
