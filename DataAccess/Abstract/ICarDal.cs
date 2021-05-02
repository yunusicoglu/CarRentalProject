using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void Add(Car car);
        void Updated(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        List<Car> GetById(int Id);
    }
}
