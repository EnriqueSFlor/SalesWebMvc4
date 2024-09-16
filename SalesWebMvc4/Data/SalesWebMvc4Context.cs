using System;

using Microsoft.EntityFrameworkCore;
using SalesWebMvc4.Models;

namespace SalesWebMvc4.Data
{
    public class SalesWebMvc4Context : DbContext
    {
        public SalesWebMvc4Context (DbContextOptions<SalesWebMvc4Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
