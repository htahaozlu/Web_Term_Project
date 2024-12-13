using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_Term_Project.Models
{
    public class Flight
    {
        public int ID { get; set; }
        
        [Required]
        public int AirportID { get; set; }
        
        [Required]
        public int CompanyID { get; set; }
        
        [Required]
        public int PlaneID { get; set; }
        
        [Required]
        public int DepartureLocationID { get; set; }
        
        [Required]
        public int ArrivalLocationID { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Navigation properties
        [ForeignKey("AirportID")]
        public virtual Airport Airport { get; set; } = null!;
        
        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; } = null!;
        
        [ForeignKey("PlaneID")]
        public virtual Plane Plane { get; set; } = null!;
        
        [ForeignKey("DepartureLocationID")]
        public virtual Location DepartureLocation { get; set; } = null!;
        
        [ForeignKey("ArrivalLocationID")]
        public virtual Location ArrivalLocation { get; set; } = null!;
        
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
} 