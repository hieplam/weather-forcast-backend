using Microsoft.EntityFrameworkCore;
using System;   

namespace weather_forcast_backend
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public string DbPath { get; private set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo { Id = 1, Temp = 14.5, FeelsLike = 5.0, TempMin = 4.0, TempMax = 19.0, Humidity = 3, Pressure = 2, CreatedAt = DateTime.Now, Note = "It's a sunny day" },
                new Todo { Id = 2, Temp = 18.5, FeelsLike = 10.0, TempMin = 9.0, TempMax = 23.0, Humidity = 1, Pressure = 1, CreatedAt = DateTime.Now, Note = "Let's go for a ride" },
                new Todo { Id = 3, Temp = 15.2, FeelsLike = 8.0, TempMin = 8.0, TempMax = 22.0, Humidity = 3, Pressure = 2, CreatedAt = DateTime.Now, Note = "Another beatiful day :)" }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
