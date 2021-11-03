using Core.Results;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int CarId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetByBrandId(int Id);
        IDataResult<List<Car>> GetByColorId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
    }
}
