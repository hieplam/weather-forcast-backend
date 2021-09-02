using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weather_forcast_backend
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public string DbPath { get; private set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo { Id = 1, Note = "Note 1" }, 
                new Todo { Id = 2, Note = "Note 1" }, 
                new Todo { Id = 3, Note = "Note 1" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
