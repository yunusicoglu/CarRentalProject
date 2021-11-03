﻿using Business.Abstract;
using Business.Constants;
using Core.Results;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2 )
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _carDal.Add(car);               
            
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==10)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == Id));
        }

        public IDataResult<List<Car>> GetByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.ColorId == Id));
        }

        public IDataResult<Car> GetById(int CarId)
        {
            return new SuccessDataResult<Car>( _carDal.Get(c => c.Id == CarId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {

            if (DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}
