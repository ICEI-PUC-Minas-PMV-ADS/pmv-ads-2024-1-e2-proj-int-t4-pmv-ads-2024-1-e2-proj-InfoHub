using Microsoft.EntityFrameworkCore;

namespace info_hub.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Noticia> Noticias { get; set; }
    }
}
