using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,ModelYear=2005,DailyPrice=400,Describtion="Benzin" },
                new Car{Id=1,BrandId=2,ColorId=3,ModelYear=2004,DailyPrice=450,Describtion="Dizel" },
                new Car{Id=1,BrandId=3,ColorId=2,ModelYear=2008,DailyPrice=500,Describtion="Dizel" },
                new Car{Id=1,BrandId=4,ColorId=2,ModelYear=2008,DailyPrice=400,Describtion="Benzin" }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => car.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Updated(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Describtion = car.Describtion;
        }
    }
}
