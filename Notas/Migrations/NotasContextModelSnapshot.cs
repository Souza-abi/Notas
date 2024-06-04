﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Notas.Data;

#nullable disable

namespace Notas.Migrations
{
    [DbContext(typeof(NotasContext))]
    partial class NotasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Notas.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoId"));

                    b.Property<string>("AlunoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prova")
                        .HasColumnType("float");

                    b.Property<double>("Teste")
                        .HasColumnType("float");

                    b.Property<double>("Trabalho")
                        .HasColumnType("float");

                    b.HasKey("AlunoId");

                    b.ToTable("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}