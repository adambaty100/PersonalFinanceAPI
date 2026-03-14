using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceAPI.Models
{
    public class Transactions
    {
        [Key]
        public Guid Id { get; set; }

        public Guid AccountId { get; set; }

        public Accounts Account { get; set; } = null!;


        public Guid CategoryId { get; set; }

        public Categories Category { get; set; } = null!;

        public double Amount { get; set; }

        public string Description { get; set; } = string.Empty;

        public DateTime TransactionDate { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
