﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_consulta_cnpj.Data.Context;

namespace api_consulta_cnpj.Data.Migrations
{
    [DbContext(typeof(cnpjcontext))]
    partial class cnpjcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("api_consulta_cnpj.Model.consultacnpj", b =>
                {
                    b.Property<string>("cnpj")
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)")
                        .HasColumnName("cnpj");

                    b.Property<string>("dadoscnpj")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("dadoscnpj");

                    b.Property<DateTime>("dataultimaatualizacao")
                        .HasColumnType("date")
                        .HasColumnName("dataultimaatualizacao");

                    b.HasKey("cnpj")
                        .HasName("pk_advogado");

                    b.ToTable("consultacnpj");

                    b
                        .HasComment("Advogados");
                });
#pragma warning restore 612, 618
        }
    }
}