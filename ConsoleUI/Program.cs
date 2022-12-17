using Business.Concrete;
using Bussiness.Concrete;
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
            //CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 3, ColorId = 1, ModelYear = 2020, DailyPrice = 175000, Description = "Megane" });

            foreach (var car in carManager.GetAll().Data)
            {
                System.Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetByBrandId(1).Data)
            {
                System.Console.WriteLine(car.Description);
            }
        }
    }
}
