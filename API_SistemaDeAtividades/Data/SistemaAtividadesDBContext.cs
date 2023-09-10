using API_SistemaDeAtividades.Data.Map;
using API_SistemaDeAtividades.Models;
using Microsoft.EntityFrameworkCore;

namespace API_SistemaDeAtividades.Data
{
    public class SistemaAtividadesDBContext : DbContext
    {
        public SistemaAtividadesDBContext(DbContextOptions<SistemaAtividadesDBContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AtividadeModel> Atividades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new AtividadeMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
