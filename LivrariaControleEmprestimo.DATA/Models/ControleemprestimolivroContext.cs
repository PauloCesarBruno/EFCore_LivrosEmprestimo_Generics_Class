﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class ControleemprestimolivroContext : DbContext
    {
        public ControleemprestimolivroContext()
        {
        }

        public ControleemprestimolivroContext(DbContextOptions<ControleemprestimolivroContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
        public virtual DbSet<VwLivroClienteEmprestimo> VwLivroClienteEmprestimo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /* Atenção: Instalar Pacotes na Biblioteca de Classe somente: 
                 * Microsoft.Extensions.Configiration.FileExtension                                                                               
                Microsoft.Extencsions.Configiration.Json                                                                                 
                Microsoft.Extensions.ConfigirationManager */                    

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                var stringConexao = configuration.GetConnectionString("Homologacao");

                optionsBuilder.UseSqlServer(stringConexao);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
            {
                entity.HasOne(d => d.LceIdClienteNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceIdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LivroClienteEmprestimo_Cliente");

                entity.HasOne(d => d.LceIdLivroNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceIdLivro)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LivroClienteEmprestimo_Livro");
            });

            modelBuilder.Entity<VwLivroClienteEmprestimo>(entity =>
            {
                entity.ToView("VW_Livro_Cliente_Emprestimo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}