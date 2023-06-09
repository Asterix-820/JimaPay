﻿using JimaPay.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JimaPay.Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
