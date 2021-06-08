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
    }
}
