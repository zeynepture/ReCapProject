using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
               new Car{Id=1 , BrandId=1, ColorId =1, ModelYear = 2020, DailyPrice=300000, Description= "Mercedes"},
               new Car{Id=2 , BrandId=2, ColorId =2, ModelYear = 1996, DailyPrice=30000, Description= "Toyota Corolla"},
               new Car{Id=3 , BrandId=3, ColorId =2, ModelYear = 2015, DailyPrice=140000, Description= "Ford Fiesta "},
               new Car{Id=4 , BrandId=4, ColorId =1, ModelYear = 2016, DailyPrice=250000, Description= "Passat"}
            };
        }

        public void Add(Car cars)
        {
            _car.Add(cars);
        }

        public void Delete(Car cars)
        {
           Car carsToDelete = _car.SingleOrDefault(p => p.Id == cars.Id);
            _car.Remove(carsToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
           return _car.Where(p => p.Id == id).ToList();

        }

        public void Update(Car cars)
        {
            Car carsToUpdate = _car.SingleOrDefault(p => p.Id == cars.Id);
            carsToUpdate.BrandId = cars.BrandId;
            carsToUpdate.ColorId = cars.ColorId;
            carsToUpdate.ModelYear = cars.ModelYear;
            carsToUpdate.DailyPrice = cars.DailyPrice;
            carsToUpdate.Description = cars.Description;
        }
    }
}
