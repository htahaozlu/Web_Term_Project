using System.ComponentModel.DataAnnotations;

namespace Web_Term_Project.Models
{
    public class Plane
    {
        public int ID { get; set; }
        
        [Required]
        public string Type { get; set; } = string.Empty;
        
        [Required]
        public int BusinessClassCapacity { get; set; }
        
        [Required]
        public int EconomyClassCapacity { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
} 