using System.ComponentModel.DataAnnotations;

namespace TravelagencyApps.Data.Domain
{
    public class Customer
    {
        public int Id { get; set; }
        

        public string FullName { get; set; } = null!;
        [Required]

        public string Email { get; set; } = null!;
        
        

        public int PhoneNumber { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; } = new List<Bookings>();

    }
}
