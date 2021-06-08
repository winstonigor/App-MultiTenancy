using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wins.AppModelo.Data;
using Wins.AppModelo.Domain;

namespace Wins.AppModelo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        sdfsdfsd
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ApplicationContext>(opt =>
            {
                opt.UseSqlite("Database Source=Database\\Tenant.db")
                .LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();

            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        /// <summary>
        /// Procedimento que vai iniciariar o banco de dados com 
        /// informações de produtos e pessoas
        /// </summary>
        /// <param name="app"></param>
        private void IniciarBaseDeDados(IApplicationBuilder app)
        {
            using var db = app.ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<ApplicationContext>();

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            for ( var i=1; i<= 5; i++)
            {
                db.Pessoas.Add(new Pessoa {Nome = $"Pessoa{i}" });
                db.Produtos.Add(new Produto {Descricao = $"Descriçãos{i}" });
            }

            db.SaveChanges();
        }
    }
}
