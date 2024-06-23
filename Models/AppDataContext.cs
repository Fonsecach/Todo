using Microsoft.EntityFrameworkCore;

namespace Todo.Models
{
    public class AppDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=todo.db");
        }
    }
}