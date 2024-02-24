

using Microsoft.EntityFrameworkCore;
using todo_backend.Models;

namespace todo_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<TodoTask> Tasks { get; set; }
    }
}
