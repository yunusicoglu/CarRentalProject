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

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());


            //brandManager.Add(new Brand { Name = "Fiat" });
            //colorManager.Add(new Color { Name = "Siyah" });
            //carManager.Update(new Car { Id=1, BrandId = 2, ColorId = 2, CarName = "Doblo", DailyPrice = 300, ModelYear = 2001, Describtion = "Benzinli" });

            //carManager.Add(new Car {  BrandId = 2, ColorId = 2, DailyPrice = 600, ModelYear = 2011, Describtion = "Dizel" });


            //GetAll(carManager);

            //ByBrandId(carManager);

            CarDetails(carManager);

            //ByColorId(carManager);
        }

        private static void ByColorId(CarManager carManager)
        {
            foreach (var car in carManager.GetByColorId(2).Data)
            {
                Console.WriteLine(car.ColorId + "  Model Yılı : " + car.ModelYear + " Fiyat : " + car.DailyPrice + "  " + car.Describtion);
            }
        }

        private static void ByBrandId(CarManager carManager)
        {
            foreach (var car in carManager.GetByBrandId(2).Data)
            {
                Console.WriteLine(car.Id + " " + car.CarName + " " + car.BrandId + "  Model Yılı : " + car.ModelYear + " Fiyat : " + car.DailyPrice + "  " + car.Describtion);
            }
        }

        private static void GetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1} {2}", car.Id, car.CarName, car.Describtion);
            }
        }

        private static void CarDetails(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} {1} {2} {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
