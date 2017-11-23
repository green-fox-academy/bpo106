using RandomProject.Entities;
using RandomProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace RandomProject.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> FilterCars (string q)
        {
            return carContext.Cars.Where(x => x.Plate.Contains(q)).ToList();
        }

        public List<Car> FilterPolice()
        {
            return carContext.Cars.Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<Car> FilterDiplomat()
        {
            return carContext.Cars.Where(x => x.Plate.StartsWith("DT")).ToList();
        }

        public List<Car> FilterBrand(string brand)
        {
            return carContext.Cars.Where(x => x.CarBrand.Equals(brand)).ToList();
        }
    }
}
