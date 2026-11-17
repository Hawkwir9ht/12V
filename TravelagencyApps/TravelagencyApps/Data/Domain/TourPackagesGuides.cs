using System.ComponentModel.DataAnnotations;

namespace TravelagencyApps.Data.Domain
{
    public class TourPackagesGuides
    {
        [Required]
        public int TourPackageId { get; set; }

        [Required]
        public int GuideId { get; set; }


    }
}
