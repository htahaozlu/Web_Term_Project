using System.ComponentModel.DataAnnotations;

namespace Web_Term_Project.Models
{
    public class Airport
    {
        public int ID { get; set; }
        
        [Required]
        public string Timezone { get; set; } = string.Empty;
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public string Country { get; set; } = string.Empty;
        
        [Required]
        public string City { get; set; } = string.Empty;
        
        public string? District { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
} 