using Microsoft.EntityFrameworkCore;
using Projeto_Aplicado.Entidades;

namespace Projeto_Aplicado.Context
{
    public class AguaContext : DbContext
    {
        public AguaContext(DbContextOptions<AguaContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<PowerBi> PowerBis { get; set; }
        public DbSet<Regiao> Regioes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioProjeto>()
                            .HasOne(up => up.Projeto)
                            .WithMany(pr => pr.UsuarioProjeto)
                            .HasForeignKey(up => up.UsuarioId);
            modelBuilder.Entity<UsuarioProjeto>()
                            .HasOne(up => up.Usuario)
                            .WithMany(u => u.UsuarioProjeto)
                            .HasForeignKey(up => up.ProjetoId);
        }
    }
}
