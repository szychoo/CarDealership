using CarDealership.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealership.DataAcessInterface
{
    public interface ICarDealershipRepository
    {
        IQueryable<Car> GetAll();

        Car GetById(int id);


    }
}
