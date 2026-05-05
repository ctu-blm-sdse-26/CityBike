using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBike.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;

namespace CityBike.Services
{
    public class BookingService
    {
        private readonly List<Booking> _bookings = new List<Booking>
        {
            new Booking
            {
                Id = 1,
                RiderId = 1,
                BikeId = 1,
                StartTime = DateTime.Now.AddHours(-2),
                EndTime = DateTime.Now.AddHours(-1),
                DurationInMinutes = 60,
                Fee = 5.00m,
                IsActive = false
            },
            new Booking
            {
                Id = 2,
                RiderId = 2,
                BikeId = 4,
                StartTime = DateTime.Now.AddHours(-1.5),
                EndTime = DateTime.Now.AddMinutes(-30),
                DurationInMinutes = 60,
                Fee = 6.50m,
                IsActive = false
            },
            new Booking
            {
                Id = 3,
                RiderId = 3,
                BikeId = 6,
                StartTime = DateTime.Now.AddMinutes(-30),
                EndTime = null,
                DurationInMinutes = null,
                Fee = null,
                IsActive = true
            }
        };

        public Booking CreateBooking(Booking booking)
        {
            if(booking == null) {return null;}
            _bookings.Add(booking);
            return booking;
        }

        public Booking ReturnBike(int BookingId)
        {
            var booking = _bookings.FirstOrDefault(b => b.Id == BookingId);
            if(booking != null)
            {
               booking.EndTime = DateTime.Now;
               booking.DurationInMinutes = (int)(booking.EndTime - booking.StartTime).Value.TotalMinutes;
            }
            return booking;
        }
    }
}