using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todoist2.Models;

namespace Todoist2.configurations;

public class TarefaConfigurations : IEntityTypeConfiguration<Tarefa>
{
    public void Configure(EntityTypeBuilder<Tarefa> builder)
    {
        builder.ToTable("tarefas");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Titulo)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.Descricao)
            .HasMaxLength(1000);

        builder.Property(u => u.Prioridade)
            .HasConversion<String>()
            .IsRequired();

        builder.Property(u => u.Concluida)
            .IsRequired()
            .HasDefaultValue(false);
    }
}