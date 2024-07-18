using Microsoft.EntityFrameworkCore;
using ToDoBack.Models;

namespace ToDoBack.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }

    }
}
