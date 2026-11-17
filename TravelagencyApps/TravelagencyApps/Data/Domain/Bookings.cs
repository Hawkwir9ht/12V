using Humanizer;

using System.ComponentModel.DataAnnotations;

namespace TravelagencyApps.Data.Domain
{
    public class Bookings
    {
        public int Id { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        

        public virtual Customer Customer { get; set; } = null!;
        public virtual TourPackages TourPackages { get; set; } = null!;
        [Required]
        public string CustomerId { get; set; } = null!;
        [Required]

        public string TourPackageId { get; set; } = null!;

    }
}
