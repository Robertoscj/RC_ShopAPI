using Microsoft.EntityFrameworkCore;
using RCShop.ProdutoAPI.Models;

namespace RCShop.ProdutoAPI.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opcoes) : base(opcoes) { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }

    //Fluent API

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // categoria
        mb.Entity<Categoria>().HasKey(c => c.CategoriaId);

        mb.Entity<Categoria>().
            Property(c => c.Nome).
             HasMaxLength(100).
               IsRequired();

        //produto
        mb.Entity<Produto>().
           Property(c => c.Nome).
            HasMaxLength(100).
              IsRequired();

        mb.Entity<Produto>().
           Property(c => c.Descricao).
            HasMaxLength(255).
              IsRequired();

        mb.Entity<Produto>().
           Property(c => c.Preco).
            HasPrecision(12,2);

        mb.Entity<Produto>().
           Property(c => c.ImageURL).
            HasMaxLength(255).
              IsRequired();

        mb.Entity<Categoria>().
           HasMany(g=>g.Produtos).
           WithOne(c => c.Categoria)
           .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
              


    }

}
