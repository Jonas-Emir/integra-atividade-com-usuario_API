using API_SistemaDeAtividades.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_SistemaDeAtividades.Data.Map
{
    public class AtividadeMap : IEntityTypeConfiguration<AtividadeModel>
    {
        public void Configure(EntityTypeBuilder<AtividadeModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(1000);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
