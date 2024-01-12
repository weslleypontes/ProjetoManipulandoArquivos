using Microsoft.EntityFrameworkCore;
using LeituraArquivos.Models;
namespace LeituraArquivos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        
            //EntityFrameworkCore\Add-Migration EntityFrameworkCore\Update-DataBase
        public DbSet<NFe> NFes { get; set; }
        public DbSet<Emitente> Emitentes { get; set; }
        public DbSet<Destinatario> Destinatarios { get; set; }
        public DbSet<ProdServ> ProdServs { get; set; }
        
    }
}
