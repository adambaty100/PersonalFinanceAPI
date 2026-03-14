using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceAPI.Models
{
    public enum TransactionType
    {
        Expense,
        Income
    }

    public class Categories
    {
        [Key]
        public Guid Id { get; set; }
        
        public Guid UserId { get; set; }

        public Users User { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;
        
        public TransactionType Type { get; set; }
    }
}
