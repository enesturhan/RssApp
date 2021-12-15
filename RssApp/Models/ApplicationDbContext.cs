using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RssApp.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=NewsApp;uid=sa;pwd=1234;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<New> News { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
