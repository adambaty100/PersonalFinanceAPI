using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using PersonalFinanceAPI.Models;

namespace PersonalFinanceAPI.Data
{
    public class PersonalFinanceContext : DbContext
    {
        public PersonalFinanceContext(DbContextOptions<PersonalFinanceContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; } = null!;
    }
}
