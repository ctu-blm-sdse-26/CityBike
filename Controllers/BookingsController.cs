using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBike.DTO;
using CityBike.Models;
using CityBike.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityBike.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController(BookingService service, BikeService bikeService, RiderService riderService) : ControllerBase
    {
        private readonly BookingService service = service;
        private readonly BikeService bikeService = bikeService;
        private readonly RiderService riderService = riderService;

        [HttpPost]
        public IActionResult CreateBooking([FromBody] BookingRequest request)
        {
            Bike bike = bikeService.GetById(request.BikeId);
            Rider rider = riderService.GetById(request.RiderId);

            Booking booking = service.CreateBooking(new Booking
            {
                Id = new Random().Next(1, 1000),
                RiderId = request.RiderId,
                BikeId = request.BikeId,
                bike = bike,
                rider = rider,
                EndTime = request.EndTime,
                Fee = request.fee,
                IsActive = request.IsActive
            });

            return Ok(new { Message = "Booking created successfully", Booking = booking });
        }

        [HttpPut("{id}/return")]
        public IActionResult ReturnBike([FromRoute] int id)
        {
            Booking updatedBooking = service.ReturnBike(id);
            return Ok(new { Message = "Bike returned successfully", Booking = updatedBooking });
        }
    }


}