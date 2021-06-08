﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wins.AppModelo.Data;

namespace Wins.AppModelo.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Wins.AppModelo.Domain.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Pessoa 1",
                            TenantId = "tenant-1"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Pessoa 2",
                            TenantId = "tenant-2"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Pessoa 3",
                            TenantId = "tenant-2"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Pessoa 4",
                            TenantId = "tenant-3"
                        });
                });

            modelBuilder.Entity("Wins.AppModelo.Domain.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Produto 1",
                            TenantId = "tenant-1"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Produto 2",
                            TenantId = "tenant-2"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Produto 3",
                            TenantId = "tenant-2"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Produto 4",
                            TenantId = "tenant-3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
