using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TraningDiary.Models;

namespace TraningDiary.Models
{
    public class TraningDiaryDbContext : IdentityDbContext<User>
    {
        //protected void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    // Customize the ASP.NET Identity model and override the defaults if needed.
        //    // For example, you can rename the ASP.NET Identity table names and more.
        //    // Add your customizations after calling base.OnModelCreating(builder);
        //}

        public TraningDiaryDbContext(DbContextOptions<TraningDiaryDbContext> options)
        : base(options)
        { }

        public DbSet<Workout> Workout { get; set; }
        public DbSet<WorkoutType> WorkoutType { get; set; }
    }
}
