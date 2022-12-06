using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestExample.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiRestExample.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<Produto> Produtos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Categoria>().ToTable("Categorias");
            builder.Entity<Categoria>().HasKey(prop=>prop.Id);
            builder.Entity<Categoria>().Property(prop=>prop.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Categoria>().Property(prop=>prop.Nome).IsRequired().HasMaxLength(30);
            builder.Entity<Categoria>().HasMany(prop=>prop.Produtos).WithOne(prop=>prop.Categoria).HasForeignKey(prop=>prop.CategoriaId);


            builder.Entity<Produto>().ToTable("Produtos");
            builder.Entity<Produto>().HasKey(prop=>prop.Id);
            builder.Entity<Produto>().Property(prop=>prop.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Produto>().Property(prop=>prop.Nome).IsRequired().HasMaxLength(20);
            builder.Entity<Produto>().Property(prop=>prop.Quantidade).IsRequired();
            builder.Entity<Produto>().Property(prop=>prop.unidMedida).IsRequired();
        }
    }
}