using CarDealership.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealership.DataAcessInterface
{
    interface CarDealershipRepository
    {
        ICollection<Car> GetAll();

        Car GetById(int id);


    }
}
