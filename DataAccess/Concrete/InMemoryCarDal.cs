using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=500,Desciption="Renault",ModelYear=DateTime.Now},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=1000,Desciption="BMW",ModelYear=DateTime.Now},
                new Car{Id=3,BrandId=1,ColorId=3,DailyPrice=400,Desciption="Renault 308",ModelYear=DateTime.Now},
                new Car{Id=4,BrandId=2,ColorId=4,DailyPrice=2000,Desciption="BMW 5.0",ModelYear=DateTime.Now}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int id)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car carToGet = _cars.SingleOrDefault(c => c.Id == id);
            return carToGet;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Desciption = car.Desciption;

        }
    }
}
