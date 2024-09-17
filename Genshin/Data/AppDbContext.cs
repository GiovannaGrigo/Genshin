using Genshin.Models;
using Microsoft.EntityFrameworkCore;

namespace Genshin.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {    
    }

    public DbSet<Arma> Armas { get; set; }
    public DbSet<Elemento> Elementos { get; set; }
    public DbSet<Personagem> Personagens { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
