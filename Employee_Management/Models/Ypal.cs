using System.ComponentModel.DataAnnotations;

namespace Employee_Management.Models
{
    public class Ypal
    {
        [Required]
        public string? YpalID { get; set; }
        [Required]
        public string? YpalName { get; set; }
        [Required]
        public string? YpalEmail { get; set; }

    }
}
