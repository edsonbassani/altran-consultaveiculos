﻿// <auto-generated />
using DevCo.ConsultaVeiculos.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DevCo.ConsultaVeiculos.WebAPI.Migrations
{
    [DbContext(typeof(VeiculosContext))]
    [Migration("20200125190100_DBCreate")]
    partial class DBCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DevCo.ConsultaVeiculos.WebAPI.Veiculos", b =>
                {
                    b.Property<int>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Ano_Fabricacao")
                        .HasColumnType("smallint")
                        .HasMaxLength(4);

                    b.Property<short>("Ano_Modelo")
                        .HasColumnType("smallint")
                        .HasMaxLength(4);

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(7)")
                        .HasMaxLength(7);

                    b.Property<string>("Proprietario")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("Veiculo_Roubado")
                        .HasColumnType("bit");

                    b.HasKey("IdVeiculo");

                    b.ToTable("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
