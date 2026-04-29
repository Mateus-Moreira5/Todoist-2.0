using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todoist2.Models;

namespace Todoist2.configurations;

public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuarios");
        
        builder.HasKey(u => u.Id);
        
        builder.Property(u => u.Nome)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(u => u.Senha)
            .IsRequired();

        builder.HasMany(u => u.Tarefas)
            .WithOne(t => t.Usuario)
            .HasForeignKey(u => u.IdUsuario)
            .OnDelete(DeleteBehavior.Cascade);
    }
}