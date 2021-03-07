using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{ 
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car cars);
        void Update(Car cars);
        void Delete(Car cars);
        List<Car> GetById(int id);
    }
}
