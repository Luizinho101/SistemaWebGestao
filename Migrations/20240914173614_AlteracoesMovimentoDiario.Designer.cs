﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaWebGestao.Data.ApplicationDbContext;

#nullable disable

namespace SistemaWebGestao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240914173614_AlteracoesMovimentoDiario")]
    partial class AlteracoesMovimentoDiario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaWebGestao.Models.Contribuicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContribuinteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPrevista")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MensageiroId")
                        .HasColumnType("int");

                    b.Property<string>("Recibo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContribuinteId");

                    b.HasIndex("MensageiroId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("Contribuicoes");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.Contribuinte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contribuintes");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.Mensageiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mensageiros");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.MovimentoDiario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContribuicaoId")
                        .HasColumnType("int");

                    b.Property<int>("ContribuinteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataMovimento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrevista")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataRecebimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("MensageiroId")
                        .HasColumnType("int");

                    b.Property<string>("Recibo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReciboId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ContribuicaoId");

                    b.HasIndex("ContribuinteId");

                    b.HasIndex("MensageiroId");

                    b.HasIndex("TipoPagamentoId");

                    b.ToTable("MovimentoDiarios");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.TiposPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposPagamentos");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.Contribuicao", b =>
                {
                    b.HasOne("SistemaWebGestao.Models.Contribuinte", "Contribuinte")
                        .WithMany()
                        .HasForeignKey("ContribuinteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWebGestao.Models.Mensageiro", "Mensageiro")
                        .WithMany()
                        .HasForeignKey("MensageiroId");

                    b.HasOne("SistemaWebGestao.Models.TiposPagamento", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contribuinte");

                    b.Navigation("Mensageiro");

                    b.Navigation("TipoPagamento");
                });

            modelBuilder.Entity("SistemaWebGestao.Models.MovimentoDiario", b =>
                {
                    b.HasOne("SistemaWebGestao.Models.Contribuicao", "Contribuicao")
                        .WithMany()
                        .HasForeignKey("ContribuicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWebGestao.Models.Contribuinte", "Contribuinte")
                        .WithMany()
                        .HasForeignKey("ContribuinteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWebGestao.Models.Mensageiro", "Mensageiro")
                        .WithMany()
                        .HasForeignKey("MensageiroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaWebGestao.Models.TiposPagamento", "TipoPagamento")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contribuicao");

                    b.Navigation("Contribuinte");

                    b.Navigation("Mensageiro");

                    b.Navigation("TipoPagamento");
                });
#pragma warning restore 612, 618
        }
    }
}
