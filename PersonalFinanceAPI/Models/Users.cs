using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceAPI.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
        
        public DateTime CreatedAt { get; set; }
        
        public DateTime UpdatedAt { get; set; }
    }
}
