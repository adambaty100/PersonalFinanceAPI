namespace PersonalFinanceAPI.Models
{
    public class UsersModel
    {
        // PK
        public Guid Id { get; set; }
        // Unique
        public required string Email { get; set; }
        // Hash
        public required string PasswordHash { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        // Audit
        public DateTime CreatedAt { get; set; }
        //Audit
        public DateTime UpdatedAt { get; set; }
    }
}
