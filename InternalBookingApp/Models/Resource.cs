using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InternalBookingApp.Models
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number")]
        public int Capacity { get; set; }

        public bool IsAvailable { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}

