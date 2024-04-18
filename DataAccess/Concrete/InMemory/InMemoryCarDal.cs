using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car { BrandId = 1, ColorId = 1, DailyPrice = 50, Description = "asaf", Id = 1, ModelYear = 2005 }, 
                new Car { BrandId = 2, ColorId = 2, DailyPrice = 500, Description = "asafsds", Id = 2, ModelYear = 2008 }, 
                new Car { BrandId = 3, ColorId = 3, DailyPrice = 5000, Description = "asafdsad", Id = 3, ModelYear = 2001 }, 
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {

            return _cars.SingleOrDefault(car => car.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.BrandId=car.BrandId;
            
        }
    }
}
