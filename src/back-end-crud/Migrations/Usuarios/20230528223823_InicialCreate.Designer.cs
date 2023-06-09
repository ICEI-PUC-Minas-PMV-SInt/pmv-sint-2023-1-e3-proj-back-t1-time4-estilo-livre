﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_end_crud.Models;

namespace back_end_crud.Migrations.Usuarios
{
    [DbContext(typeof(UsuariosContext))]
    [Migration("20230528223823_InicialCreate")]
    partial class InicialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("back_end_crud.Models.Usuarios", b =>
                {
                    b.Property<string>("EmpCode")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmpCode");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
