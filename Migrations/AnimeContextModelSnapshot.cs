﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(AnimeContext))]
    partial class AnimeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Anime", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("anime");
                });

            modelBuilder.Entity("Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("estado");
                });

            modelBuilder.Entity("Personaje", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Altura")
                        .HasColumnType("REAL");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Estadosid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Frase")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Habilidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Latitud")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Longitud")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pronunciacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sexoid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vestimenta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("animeid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("Estadosid");

                    b.HasIndex("Sexoid");

                    b.HasIndex("animeid");

                    b.ToTable("personaje");
                });

            modelBuilder.Entity("Sexo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("sexo");
                });

            modelBuilder.Entity("Personaje", b =>
                {
                    b.HasOne("Estado", "Estados")
                        .WithMany()
                        .HasForeignKey("Estadosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sexo", "Sexo")
                        .WithMany()
                        .HasForeignKey("Sexoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Anime", "anime")
                        .WithMany()
                        .HasForeignKey("animeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estados");

                    b.Navigation("Sexo");

                    b.Navigation("anime");
                });
#pragma warning restore 612, 618
        }
    }
}
