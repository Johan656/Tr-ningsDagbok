using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using TheTraningdiaryProject.Models;

namespace TheTraningdiaryProject.Models
{
    public class ApplicationDbContext : DbContext
    {
        //protected void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    // Customize the ASP.NET Identity model and override the defaults if needed.
        //    // For example, you can rename the ASP.NET Identity table names and more.
        //    // Add your customizations after calling base.OnModelCreating(builder);
        //}
        public DbSet<Workout> Workout { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Speed> Speed { get; set; }
        public DbSet<Endurance> Endurance { get; set; }
        public DbSet<Strength> Strength { get; set; }
        public DbSet<Rest> Rest { get; set; }
        public DbSet<Mobility> Mobility { get; set; }
        public DbSet<WorkoutType> WorkoutType { get; set; }

    }
}
