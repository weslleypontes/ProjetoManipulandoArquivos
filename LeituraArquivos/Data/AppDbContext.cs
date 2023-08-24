using Microsoft.EntityFrameworkCore;
using LeituraArquivos.Models;
namespace LeituraArquivos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<NFe> NFes { get; set; }
    }
}
