using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Desciption);
            }

            Console.WriteLine("----------------------------------");

            Car car1 = new Car() { Desciption = "Hyundai",Id = 10,BrandId=3,ColorId=2,DailyPrice=350,ModelYear=DateTime.Now};
            Car car2 = new Car() { Desciption = "Hyundaiupdated", Id = 10, BrandId = 3, ColorId = 2, DailyPrice = 750, ModelYear = DateTime.Now };

            carManager.Add(car1);

            Console.WriteLine("-----------New Car Added----------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Desciption);
            }

            Console.WriteLine("-----------id 3 deleted ----------");
            carManager.Delete(3);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Desciption);
            }

            Console.WriteLine("-----------id 10 updated----------");
            carManager.Update(car2);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " + car.Desciption);
            }

            Console.WriteLine("-----------id 10 listed ----------");
            Console.WriteLine(carManager.GetById(10).Desciption);

        }
    }
}
