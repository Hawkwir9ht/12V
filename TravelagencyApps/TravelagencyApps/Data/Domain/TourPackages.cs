using System.ComponentModel.DataAnnotations;

namespace TravelagencyApps.Data.Domain
{
    public class TourPackages
    {
        public int Id { get; set; }
        [Required]

        public string PackageName { get; set; } = null!;
        

        public string Description { get; set; } = null!;
        [Required]

        public decimal Price { get; set; }
        
        public virtual IEnumerable<Bookings> Bookings { get; set; } = new List<Bookings>();

        public virtual TourPackagesGuides TourPackagesGuides { get; set; } = null!;
        
    }
}
