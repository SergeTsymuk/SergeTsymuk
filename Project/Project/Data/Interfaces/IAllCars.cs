using Project.Models;
using System.Collections.Generic;

namespace Project.Interfaces
{
    public interface IAllCars
    {
        Car GetCarById(int carId);
        IEnumerable<Car> GetFavourCars { get; set; }
        IEnumerable<Car> GetAllCars { get; }
    }
}
