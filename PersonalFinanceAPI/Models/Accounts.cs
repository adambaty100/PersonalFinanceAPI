using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceAPI.Models
{
    public enum AccountTypes
    {
        Checking,
        Savings,
        Credit,
        Investing
    }

    public class Accounts
    {
        [Key]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Users User { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public AccountTypes Type { get; set; }
        
        [Required]
        public string Currency { get; set; } = null!;
        
        public double Balance { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}
