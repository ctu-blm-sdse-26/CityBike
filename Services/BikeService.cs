using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBike.Models;
using CityBike.Enums;

namespace CityBike.Services
{
    public class BikeService
    {
        private readonly List<Bike> _bikes = new List<Bike>
        {
            new Bike { Id = 1, Model = "City Cruiser", City = "Prague", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 2, Model = "Metro Commuter", City = "Prague", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 3, Model = "Vintage Tourer", City = "Prague", IsAvailable = false, Status = Status.InUse, Bookings = new List<Booking>() },
            new Bike { Id = 4, Model = "Speedster", City = "Ostrava", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 5, Model = "Urban Rider", City = "Ostrava", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 6, Model = "Electric Glide", City = "Brno", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 7, Model = "Park Hopper", City = "Brno", IsAvailable = false, Status = Status.Maintenance, Bookings = new List<Booking>() },
            new Bike { Id = 8, Model = "River Runner", City = "Plzen", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 9, Model = "Night Shift", City = "Plzen", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() },
            new Bike { Id = 10, Model = "Sunset Cruiser", City = "Prague", IsAvailable = true, Status = Status.Available, Bookings = new List<Booking>() }
        };

        public List<Bike> GetAvailableBikes(string city)
        {
            return _bikes.Where(bike => bike.City == city && bike.IsAvailable).ToList();
        }

        public Bike GetById(int bikeId)
        {
            return _bikes.FirstOrDefault(b => b.Id == bikeId);
        }
    }
}