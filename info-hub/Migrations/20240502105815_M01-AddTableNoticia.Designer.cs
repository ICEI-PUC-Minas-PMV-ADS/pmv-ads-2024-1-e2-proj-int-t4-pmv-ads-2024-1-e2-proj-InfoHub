﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using info_hub.Models;

#nullable disable

namespace info_hub.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240502105815_M01-AddTableNoticia")]
    partial class M01AddTableNoticia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("info_hub.Models.Noticia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("string");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DataPublicacao")
                        .HasColumnType("string");

                    b.Property<string>("Tema")
                        .HasColumnType("string");

                    b.Property<string>("Titulo")
                        .HasColumnType("string");

                    b.HasKey("Id");

                    b.ToTable("Noticias");
                });
#pragma warning restore 612, 618
        }
    }
}
