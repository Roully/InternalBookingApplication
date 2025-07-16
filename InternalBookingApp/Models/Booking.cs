using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalBookingApp.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; } = DateTime.Now.AddHours(1);

        [Required]
        [Display(Name = "Booked By")]
        public string BookedBy { get; set; } = string.Empty;

        [Required]
        public string Purpose { get; set; } = string.Empty;

        // Foreign key
        [Display(Name = "Resource")]
        public int ResourceId { get; set; }

        // Navigation property
        public Resource? Resource { get; set; }
    }
}
