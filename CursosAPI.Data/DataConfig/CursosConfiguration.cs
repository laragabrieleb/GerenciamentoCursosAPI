using CursosAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursosAPI.Data.DataConfig
{
    public class CursosConfiguration : IEntityTypeConfiguration<EntidadeCursos>
    {
        public void Configure(EntityTypeBuilder<EntidadeCursos> builder)
        {
            builder.ToTable("Cursos");
            builder.HasKey(k => k.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.Property(x => x.Valor)
                .HasColumnType("decimal")
                .HasPrecision(18,2)
                .IsRequired();
        }
    }
}
