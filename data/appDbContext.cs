using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Todoist2.Models;

namespace Todoist2.data;

public class appDbContext : DbContext
{
    public appDbContext(DbContextOptions<appDbContext> options) : base(options) { }
    
    public DbSet<Usuario> usuario { get; set; }
    public DbSet<Tarefa> tarefa { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}