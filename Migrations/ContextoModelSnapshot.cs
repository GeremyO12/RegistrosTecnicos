﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrosTecnicos.DAL;

#nullable disable

namespace RegistrosTecnicos.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("RegistrosTecnicos.Models.Tecnicos", b =>
                {
                    b.Property<int>("IdTecnico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("SueldoHora")
                        .HasColumnType("REAL");

                    b.Property<int>("TipoTecnicoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdTecnico");

                    b.HasIndex("TipoTecnicoId");

                    b.ToTable("Tecnicos");
                });

            modelBuilder.Entity("RegistrosTecnicos.Models.TiposTecnicos", b =>
                {
                    b.Property<int>("TipoTecnicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TipoTecnicoId");

                    b.ToTable("TiposTecnicos");
                });

            modelBuilder.Entity("RegistrosTecnicos.Models.Tecnicos", b =>
                {
                    b.HasOne("RegistrosTecnicos.Models.TiposTecnicos", "TipoTecnico")
                        .WithMany("Tecnicos")
                        .HasForeignKey("TipoTecnicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoTecnico");
                });

            modelBuilder.Entity("RegistrosTecnicos.Models.TiposTecnicos", b =>
                {
                    b.Navigation("Tecnicos");
                });
#pragma warning restore 612, 618
        }
    }
}
