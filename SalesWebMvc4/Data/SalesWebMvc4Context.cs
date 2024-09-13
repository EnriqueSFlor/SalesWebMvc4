using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc1.Models;

namespace SalesWebMvc4.Data
{
    public class SalesWebMvc4Context : DbContext
    {
        public SalesWebMvc4Context (DbContextOptions<SalesWebMvc4Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc1.Models.Department> Department { get; set; }
    }
}
