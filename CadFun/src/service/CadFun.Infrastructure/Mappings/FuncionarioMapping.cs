using CadFun.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CadFun.Infrastructure.Mappings
{
    public class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeCompleto)
                .IsRequired()
                .HasColumnName("nome_completo")
                .HasColumnType("varchar(300)");

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasColumnType("varchar(12)");

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.ToTable("TB_Funcionarios");
        }
    }
}
