using api_consulta_cnpj.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_consulta_cnpj.Data.Mapping
{
    internal class consultacnpjMap : IEntityTypeConfiguration<consultacnpj>
    {
        public void Configure(EntityTypeBuilder<consultacnpj> entity)
        {
            entity.ToTable("consultacnpj");

            entity.HasComment("Advogados");

            entity.HasKey(e => e.cnpj)
                  .HasName("pk_advogado");

            entity.Property(e => e.cnpj)
                  .HasColumnName("cnpj")
                  .IsRequired()
                  .HasMaxLength(14);

            entity.Property(e => e.dadoscnpj)
                  .HasColumnName("dadoscnpj")
                  .IsRequired();

            entity.Property(e => e.dataultimaatualizacao)
                  .HasColumnName("dataultimaatualizacao")
                  .HasColumnType("date");
        }
    }
}