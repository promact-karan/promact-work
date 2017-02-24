using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_manage
{
    public class Context : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<UpdateProduct> UpdateProduct { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer(@"Server = (LocalDb)\MSSQLLocalDB; Database = product_manage1.dbo");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
