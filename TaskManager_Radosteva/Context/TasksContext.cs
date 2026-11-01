using Microsoft.EntityFrameworkCore;
using TaskManager_Radosteva.Classes.Database;
using TaskManager_Radosteva.Models;

namespace TaskManager_Radosteva.Context
{
    public class TasksContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public TasksContext() 
        {
            Database.EnsureCreated();
            Tasks.Load();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Config.connection, Config.version);
        }
    }
}
