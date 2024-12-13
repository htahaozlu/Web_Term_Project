using System.ComponentModel.DataAnnotations;

namespace Web_Term_Project.Models
{
    public class Payment
    {
        public int ID { get; set; }
        
        [Required]
        public string FullName { get; set; } = string.Empty;
        
        [Required]
        public string CardNumber { get; set; } = string.Empty;
        
        [Required]
        public string ExpiryDate { get; set; } = string.Empty;
        
        [Required]
        public string CVV { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }
    }
} 