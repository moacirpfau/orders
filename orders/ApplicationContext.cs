using Microsoft.EntityFrameworkCore;
using orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orders
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Orders>().HasKey(t => new { t.ID, t.ITEM });
        }
        
        public DbSet<Orders> Orders { get; set; }
    }
}
