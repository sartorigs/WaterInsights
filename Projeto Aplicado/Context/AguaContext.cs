using Microsoft.EntityFrameworkCore;
using Projeto_Aplicado.Entidades;

namespace Projeto_Aplicado.Context
{
    public class AguaContext : DbContext
    {
        public AguaContext(DbContextOptions<AguaContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<PowerBi> PowerBis { get; set; }
        public DbSet<Regiao> Regioes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(x => x.Projetos)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId);
        }
    }
}
