using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData(
                new TaskItem { Id = 1, Title = "Задача 1", Description = "Описание 1", CreatedDate = new DateTime(2026, 11, 17, 18, 9, 0, DateTimeKind.Utc) },
                new TaskItem { Id = 2, Title = "Задача 2", Description = "Описание 2", CreatedDate = new DateTime(2026, 11, 17, 18, 9, 0, DateTimeKind.Utc) },
                new TaskItem { Id = 3, Title = "Задача 3", Description = "Описание 3", CreatedDate = new DateTime(2026, 11, 17, 18, 9, 0, DateTimeKind.Utc) },
                new TaskItem { Id = 4, Title = "Задача 4", Description = "Описание 4", CreatedDate = new DateTime(2026, 11, 17, 18, 9, 0, DateTimeKind.Utc) }
            );
        }
    }
}
