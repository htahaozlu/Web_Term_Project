using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Term_Project.Models
{
    public class Location
    {
        public int ID { get; set; }
        
        public int? ParentID { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("ParentID")]
        public virtual Location? Parent { get; set; }
        public virtual ICollection<Location> Children { get; set; } = new List<Location>();
        public virtual ICollection<Flight> DepartureFlights { get; set; } = new List<Flight>();
        public virtual ICollection<Flight> ArrivalFlights { get; set; } = new List<Flight>();
    }
} 