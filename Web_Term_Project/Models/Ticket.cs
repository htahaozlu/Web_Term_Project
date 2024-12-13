using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Term_Project.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        
        [Required]
        public int CustomerID { get; set; }
        
        [Required]
        public int FlightID { get; set; }
        
        [Required]
        public string PNR { get; set; } = string.Empty;
        
        [Required]
        public string SeatNumber { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; } = null!;
        
        [ForeignKey("FlightID")]
        public virtual Flight Flight { get; set; } = null!;
    }
} 