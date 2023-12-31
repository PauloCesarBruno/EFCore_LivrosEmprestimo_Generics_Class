﻿// <auto-generated />
using System;
using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LivrariaControleEmprestimo.DATA.Migrations
{
    [DbContext(typeof(ControleemprestimolivroContext))]
    partial class ControleemprestimolivroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CliBairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("cliBairro");

                    b.Property<string>("CliCidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("cliCidade");

                    b.Property<string>("CliCpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("cliCPF");

                    b.Property<string>("CliEndereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("cliEndereco");

                    b.Property<string>("CliNome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("cliNome");

                    b.Property<string>("CliNumero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cliNumero");

                    b.Property<string>("CliTelefoneFixo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cliTelefoneFixo");

                    b.Property<string>("CliTeleoneCelular")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cliTeleoneCelular");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LivroAnoPublicacao")
                        .HasColumnType("datetime")
                        .HasColumnName("livroAnoPublicacao");

                    b.Property<string>("LivroAutor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("livroAutor");

                    b.Property<string>("LivroEdicao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("livroEdicao");

                    b.Property<string>("LivroEditora")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("livroEditora");

                    b.Property<string>("LivroNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("livroNome");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.LivroClienteEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LceDataEmprestimo")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LceDataEntrega")
                        .HasColumnType("datetime");

                    b.Property<bool>("LceEntregue")
                        .HasColumnType("bit");

                    b.Property<int>("LceIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("LceIdLivro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LceIdCliente");

                    b.HasIndex("LceIdLivro");

                    b.ToTable("LivroClienteEmprestimo");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.VwLivroClienteEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CliCpf")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("cliCPF");

                    b.Property<string>("CliNome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("cliNome");

                    b.Property<DateTime>("LceDataEmprestimo")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("LceDataEntrega")
                        .HasColumnType("datetime");

                    b.Property<bool>("LceEntregue")
                        .HasColumnType("bit");

                    b.Property<int>("LceIdCliente")
                        .HasColumnType("int");

                    b.Property<int>("LceIdLivro")
                        .HasColumnType("int");

                    b.Property<string>("LivroNome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("livroNome");

                    b.HasKey("Id");

                    b.ToView("VW_Livro_Cliente_Emprestimo");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.LivroClienteEmprestimo", b =>
                {
                    b.HasOne("LivrariaControleEmprestimo.DATA.Models.Cliente", "LceIdClienteNavigation")
                        .WithMany("LivroClienteEmprestimo")
                        .HasForeignKey("LceIdCliente")
                        .HasConstraintName("FK_LivroClienteEmprestimo_Cliente")
                        .IsRequired();

                    b.HasOne("LivrariaControleEmprestimo.DATA.Models.Livro", "LceIdLivroNavigation")
                        .WithMany("LivroClienteEmprestimo")
                        .HasForeignKey("LceIdLivro")
                        .HasConstraintName("FK_LivroClienteEmprestimo_Livro")
                        .IsRequired();

                    b.Navigation("LceIdClienteNavigation");

                    b.Navigation("LceIdLivroNavigation");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.Cliente", b =>
                {
                    b.Navigation("LivroClienteEmprestimo");
                });

            modelBuilder.Entity("LivrariaControleEmprestimo.DATA.Models.Livro", b =>
                {
                    b.Navigation("LivroClienteEmprestimo");
                });
#pragma warning restore 612, 618
        }
    }
}
