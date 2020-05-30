using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // in this step we made the id for the two tables primary key to added automatically
        // bacause we defined the Id with type Guid
        // if we defined the id with type int we don't need this step
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = Guid.NewGuid(),
                    FullName = "Ahmed Yehia",
                    Position = "Software Enginner",
                    Avatar = "about.jpg"
                }
                );
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}
