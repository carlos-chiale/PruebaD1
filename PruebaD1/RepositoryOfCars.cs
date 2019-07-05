using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaD1
{
    public class RepositoryOfCars
    {
        public void Add(Car oneCar)
        {
            using (var context = new MyContext())
            {
                context.Cars.Add(oneCar);
                context.SaveChanges();
            }
        }

        public void Modify(String carName, String newCarName, String newModel, DateTime newDateOfCensus)
        {
            using (var context = new MyContext())
            {
                var car = context.Cars.First(theCar => theCar.Name == carName);
                car.Name = newCarName;
                car.Model = newModel;
                car.DateOfCensus = newDateOfCensus;
                context.SaveChanges();
            }
        }

        public void Delete(string aNameOfCar)
        {
            using (var context = new MyContext())
            {
                var carToDelete = context.Cars.FirstOrDefault(theMobile => theMobile.Name == aNameOfCar);
                if (carToDelete != null)
                {
                    context.Cars.Attach(carToDelete);
                    context.Cars.Remove(carToDelete);
                    context.SaveChanges();
                }
            }
        }

        public Car Get(String aNameOfCar)
        {
            using (var context = new MyContext())
            {
                return context.Cars.FirstOrDefault(theCar => theCar.Name == aNameOfCar);
            }
        }
    }
}
