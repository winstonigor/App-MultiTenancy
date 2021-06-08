using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wins.AppModelo.Domain;

namespace Wins.AppModelo.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext>options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasData(
                new Pessoa { Id = 1, Nome = "Pessoa 1", TenantId = "tenant-1" },
                new Pessoa { Id = 2, Nome = "Pessoa 2", TenantId = "tenant-2" },
                new Pessoa { Id = 3, Nome = "Pessoa 3", TenantId = "tenant-2" },
                new Pessoa { Id = 4, Nome = "Pessoa 4", TenantId = "tenant-3" });

            modelBuilder.Entity<Produto>().HasData(
                new Produto { Id = 1, Descricao = "Produto 1", TenantId = "tenant-1" },
                new Produto { Id = 2, Descricao = "Produto 2", TenantId = "tenant-2" },
                new Produto { Id = 3, Descricao = "Produto 3", TenantId = "tenant-2" },
                new Produto { Id = 4, Descricao = "Produto 4", TenantId = "tenant-3" });
                
        }
    }
}
