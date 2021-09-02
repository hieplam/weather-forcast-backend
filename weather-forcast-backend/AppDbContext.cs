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
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
        }

        //// The following configures EF to create a Sqlite database file in the
        //// special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");
    }
}
