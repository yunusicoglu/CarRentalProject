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
            //brandManager.Add(new Brand { Name = "Fiat" });
            //colorManager.Add(new Color { Name = "Siyah" });
            //carManager.Update(new Car { Id=1, BrandId = 2, ColorId = 2, CarName = "Doblo", DailyPrice = 300, ModelYear = 2001, Describtion = "Benzinli" });
            //carManager.Add(new Car {  BrandId = 2, ColorId = 2, DailyPrice = 600, ModelYear = 2011, Describtion = "Dizel" });
            //customerManager.Add(new Customer { UserId=2, CompanyName="Mekke Mescidi"});
            //userManager.Add(new User { FirstName="Emrullah", LastName="Ince", Email="emr576846@gmail.com", Password="emr123"});
            //rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now.Date, ReturnDate = DateTime.Now.Date });

            //GetCarDetails(carManager);
            //GetAllUser();
            //GetAllCar();
            GetAllRental();

        }

        private static void GetAllRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());          
            
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", rental.CarId, rental.CustomerId, rental.RentDate.ToString(), rental.ReturnDate.ToString());
            }
        }

        private static void GetAllCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1} {2}", car.Id, car.CarName, car.Describtion);
            }
        }

        private static void GetAllUser()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("{0} {1} {2}", user.FirstName, user.LastName, user.Email);
            }
        }
       

        private static void GetCarDetails(CarManager carManager)
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
