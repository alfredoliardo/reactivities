using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Value>()
            .HasData(
                new Value{Id = 1, Name = "Valore 101"},
                new Value{Id = 2, Name = "Valore 102"},
                new Value{Id = 3, Name = "Valore 103"}
            );
        }

        public DbSet<Value> Values {get ; set ; }
    }
}
