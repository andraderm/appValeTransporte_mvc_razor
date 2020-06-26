﻿// <auto-generated />
using System;
using AppVT_MVC_Razor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppVT_MVC_Razor.Migrations
{
    [DbContext(typeof(AppVT_MVC_RazorContext))]
    partial class AppVT_MVC_RazorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppVT_MVC_Razor.Models.Escala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EscalaTrabalho")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Escalas");
                });

            modelBuilder.Entity("AppVT_MVC_Razor.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CustoVT")
                        .HasColumnType("float");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EscalaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SetorId")
                        .HasColumnType("int");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EscalaId");

                    b.HasIndex("SetorId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("AppVT_MVC_Razor.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("AppVT_MVC_Razor.Models.Funcionario", b =>
                {
                    b.HasOne("AppVT_MVC_Razor.Models.Escala", "Escala")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EscalaId");

                    b.HasOne("AppVT_MVC_Razor.Models.Setor", "Setor")
                        .WithMany("Funcionarios")
                        .HasForeignKey("SetorId");
                });
#pragma warning restore 612, 618
        }
    }
}