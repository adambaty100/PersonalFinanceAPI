using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceAPI.Models
{
    public class Budgets
    {
        [Key]
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }

        public Categories Category { get; set; } = null!;
        
        public double Amount { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}
