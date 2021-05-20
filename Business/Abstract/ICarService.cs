using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int CarId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<Car> GetByBrandId(int Id);
        List<Car> GetByColorId(int Id);
        List<CarDetailDto> GetCarDetails();
    }
}
