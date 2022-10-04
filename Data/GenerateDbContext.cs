using GenerateReceipt.Models;
using Microsoft.EntityFrameworkCore;

namespace GenerateReceipt.Data
{
    public class GenerateDbContext: DbContext
    {
        public GenerateDbContext(DbContextOptions<GenerateDbContext> options)
            : base(options)
        {

        }

        public DbSet<Receipt<int, string>> Receipts { get; set; }
        public DbSet<Customer<int>> Customers { get; set; }
    }
}
