using Logistica.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    
    // O DbSet representa uma Tabela que vem das Entidades do Damin ao Banco de Dados
    public DbSet<Address> Address { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Receiver> Receiver { get; set; }
    public DbSet<Shipping> Shipping { get; set; }

}

