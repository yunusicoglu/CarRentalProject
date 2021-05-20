using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EFCarDal());
            BrandManager brandManager = new BrandManager(new EFBrandDal());
            ColorManager colorManager = new ColorManager(new EFColorDal());


            //brandManager.Add(new Brand { Name = "Fiat" });
            //colorManager.Add(new Color { Name = "Siyah" });
            //carManager.Add(new Car {  BrandId = 1, ColorId = 1, CarName="Doblo", DailyPrice = 300, ModelYear = 2001, Describtion = "Benzinli"});

            //carManager.Add(new Car {  BrandId = 2, ColorId = 2, DailyPrice = 600, ModelYear = 2011, Describtion = "Dizel" });
            //carManager.Delete(new Car { Id=3004, BrandId = 4, ColorId = 3, CarName = "Connect", DailyPrice = 350, ModelYear = 2004, Describtion = "Dizel" });


            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0} {1}",car.Id,car.Describtion);
            //}


            //foreach (var car in carManager.GetByBrandId(4))
            //{
            //    Console.WriteLine(car.Id+" "+car.CarName+" "+car.BrandId+"  Model Yılı : "+car.ModelYear+" Fiyat : "+car.DailyPrice+"  "+car.Describtion);
            //}

            foreach ( var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} {1} {2} {3}",car.CarName, car.BrandName ,car.ColorName, car.DailyPrice);
            }

            //foreach (var car in carManager.GetByColorId(2))
            //{
            //    Console.WriteLine(car.ColorId+ "  Model Yılı : " + car.ModelYear + " Fiyat : " + car.DailyPrice + "  " + car.Describtion);
            //}
        }
    }
}
