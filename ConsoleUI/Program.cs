﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            
            //foreach (var c in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(c.CarName+ " | " + c.BrandName + " | " +c.ColorName + " | " +  c.DailyPrice);
            //}
        }
    }
}