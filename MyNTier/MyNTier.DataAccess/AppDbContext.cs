using System;
using System.Collections.Generic;
using System.Text;
using MyNTier.Models;
using Microsoft.EntityFrameworkCore;

namespace MyNTier.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
