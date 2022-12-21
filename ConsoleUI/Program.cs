using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 2, ColorId = 1, ModelYear = 2021, DailyPrice = 1000, Description = "BMW" });
            carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = 2022, DailyPrice = 1500, Description = "Mercedes" });
            carManager.Add(new Car { BrandId = 4, ColorId = 3, ModelYear = 2023, DailyPrice = 2000, Description = "Range Rover" });
            carManager.Add(new Car { BrandId = 3, ColorId = 1, ModelYear = 2020, DailyPrice = 500, Description = "Megane" });

            foreach (var car in carManager.GetAll().Data)
            {
                System.Console.WriteLine(car.Description);
            }

            
        }
    }
}
