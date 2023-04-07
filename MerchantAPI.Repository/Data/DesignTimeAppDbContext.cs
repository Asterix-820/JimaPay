using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantAPI.Repository.Data
{
    public class DesignTimeAppDbContext : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            // pass your design time connection string here
            optionsBuilder.UseSqlServer("server=DESKTOP-FRJ8UEO\\MSSQLSERVER02;Database=MerchantDb;Trusted_Connection=True;TrustServerCertificate=Yes");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
