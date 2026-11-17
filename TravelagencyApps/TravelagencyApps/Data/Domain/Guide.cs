using System.ComponentModel.DataAnnotations;

namespace TravelagencyApps.Data.Domain
{
    public class Guide
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = null!;

        public string Language { get; set; } = null!;
    }
}
