using Microsoft.EntityFrameworkCore;

namespace PROGRAMACION1_TAREA5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Planta> Plantas { get; set; }
    }
}
