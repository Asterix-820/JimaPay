using MerchantAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace MerchantAPI
{
    public class MerchantDbContext : DbContext
    {
        public MerchantDbContext(DbContextOptions<MerchantDbContext> options) : base(options)
        {
        }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
