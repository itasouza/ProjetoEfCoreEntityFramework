using Microsoft.EntityFrameworkCore;
using ProjetoEF.Models;
using Microsoft.EntityFrameworkCore.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEF.Database
{
    public class ApplicationDbContext :DbContext
    {

       public DbSet<Funcionario> Funcionarios { get; set; }
       public DbSet<Categoria> Categoria { get; set; }
       public DbSet<Produto> Produtos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        //Fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Produto>().ToTable("");
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100);
        }


    }
}
