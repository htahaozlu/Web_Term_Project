using System.ComponentModel.DataAnnotations;

namespace Web_Term_Project.Models
{
    public class Company
    {
        public int ID { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public string? Field { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        public virtual ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
} 