using Project.Interfaces;
using Project.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        public IEnumerable<Car> GetFavourCars { get; set; }
        public IEnumerable<Car> GetAllCars { get; set; }

        public Car GetCarById(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}
