using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaD1
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositoryOfCars repositoryOfCars = new RepositoryOfCars();
            Car car1 = new Car("Auto1", "Modelo 1", DateTime.Now);
            Car car2 = new Car("Auto2", "Modelo 2", DateTime.Now);
            Car car3 = new Car("Auto3", "Modelo 3", DateTime.Now);
            Piece piece1 = new Piece("Pieza 1", DateTime.Now);
            car1.Pieces.Add(piece1);

            repositoryOfCars.Add(car1);
            repositoryOfCars.Add(car2);
            repositoryOfCars.Add(car3);

        }
    }
}
