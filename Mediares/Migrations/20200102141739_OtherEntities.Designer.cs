﻿// <auto-generated />
using Mediares.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mediares.Migrations
{
    [DbContext(typeof(MediaresContext))]
    [Migration("20200102141739_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mediares.Models.Disciplina", b =>
                {
                    b.Property<int>("DisciplinaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DisciplinaID");

                    b.ToTable("Disciplina");
                });
#pragma warning restore 612, 618
        }
    }
}
