using System;
using System.ComponentModel.DataAnnotations;

namespace CityBike.DTO;

public struct BookingRequest
{
    public BookingRequest()
    {
    }

    [Required]
    public int RiderId { get; set; }
    [Required]
    public int BikeId { get; set; }
    public DateTime? EndTime { get; set; }
    public decimal? fee { get; set; }
    public bool IsActive { get; set; } = true;

}
