using System;
using Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infraestructure.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
 partial class DataBaseContextModelSnapshot:ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128);
            modelBuilder.Entity("Infraestructure.Data.Entities.libros", b => {
                b.Property<int>("ISBN")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

                b.Property<int>("editoriales_id")
                .IsRequired()
                .HasColumnType("int");

                b.Property<string>("titulo")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.Property<string>("sinopsis")
                .IsRequired()
                .HasColumnType("TEXT");

                b.Property<string>("n_paginas")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.HasKey("ISBN");
                b.HasIndex("libros_ISBN");
                b.ToTable("autores_has_libros");
            });
            modelBuilder.Entity("Infraestructure.Data.Entities.autores", b => {
                b.Property<int>("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

                b.Property<string>("nombre")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.Property<string>("apellidos")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.HasKey("id");
                b.HasIndex("autores_id");
                b.ToTable("autores_has_libros");
            });
            modelBuilder.Entity("Infraestructure.Data.Entities.editoriales", b => {
                b.Property<int>("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int");

                b.Property<string>("nombre")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.Property<string>("sede")
                .IsRequired()
                .HasColumnType("varchar(45)");

                b.HasKey("id");
                b.HasIndex("editoriales_id");
                b.ToTable("libros");
            });
            modelBuilder.Entity("Infraestructure.Data.Entities.autores_has_libros", b => {
                b.Property<int>("autores_id")
                .HasColumnType("int");

                b.Property<int>("libros_ISBN")
               .HasColumnType("int");

                

                b.HasNoKey();
            });
        }
    }
}

