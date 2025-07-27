using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using TaskTracker.Models;

namespace TaskTracker.Data

{

    public class ApplicationDbContext : IdentityDbContext<UserInfo>

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

            : base(options)

        {

        }

        public DbSet<TaskItem> TaskItems { get; set; }

        public DbSet<TaskCategory> TaskCategories { get; set; }

        public DbSet<SubTask> SubTasks { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)

        {

            base.OnModelCreating(builder);
            builder.Entity<TaskCategory>().HasData(
                new TaskCategory { Id = 1, Name = "General" },
                new TaskCategory { Id = 2, Name = "Daily Task" }
                );
                
            // Additional model configuration can go here

            //builder.Entity<IdentityRole>().HasData(
            //    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
            //    new IdentityRole { Name = "User", NormalizedName = "USER" }
            //);
            //builder.Entity<IdentityRole>().HasData(
            //    new IdetityRole { }

        }

    }

}

