﻿// <auto-generated />
using System;
using Estoque_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Estoque_API.Migrations
{
    [DbContext(typeof(EstoqueDbContext))]
    [Migration("20231228004838_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Estoque_API.Model.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("PrecoCompra")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PrecoPrevistoVenda")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("ProdutoAVenda")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuantidadeProduto")
                        .HasColumnType("int");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
