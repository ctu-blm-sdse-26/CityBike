using System;
using CityBike.Models;
using CityBike.Enums;

namespace CityBike.Services;

public class RiderService
{
    private readonly List<Rider> _riders = new List<Rider>
    {
        new Rider { Id = 1, Name = "Alice Johnson", Email = "alice@example.com", Password = "password123", City = "Prague", FailedLoginAttempts = 0, IsBlocked = false, Role = Roles.Rider, Bookings = new List<Booking>() },
        new Rider { Id = 2, Name = "Bob Smith", Email = "bob@example.com", Password = "password123", City = "Ostrava", FailedLoginAttempts = 0, IsBlocked = false, Role = Roles.Rider, Bookings = new List<Booking>() },
        new Rider { Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", Password = "password123", City = "Brno", FailedLoginAttempts = 0, IsBlocked = false, Role = Roles.Rider, Bookings = new List<Booking>() },
        new Rider { Id = 4, Name = "Diana Prince", Email = "diana@example.com", Password = "password123", City = "Plzen", FailedLoginAttempts = 0, IsBlocked = false, Role = Roles.Rider, Bookings = new List<Booking>() },
        new Rider { Id = 5, Name = "Eve Wilson", Email = "eve@example.com", Password = "password123", City = "Prague", FailedLoginAttempts = 0, IsBlocked = false, Role = Roles.Rider, Bookings = new List<Booking>() }
    };

    public Rider GetById(int riderId)
    {
        return _riders.FirstOrDefault(r => r.Id == riderId);
    }
}
