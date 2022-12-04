using Aterdigital.Agricultores;
using Aterdigital.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace Aterdigital;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Agricultor> Agricultors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("aterdigital");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedData();

        base.OnModelCreating(modelBuilder);
    }
}