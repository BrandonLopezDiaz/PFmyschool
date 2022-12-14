// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFmyschool.Context;

namespace PFmyschool.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221109165555_MythSchoolDB")]
    partial class MythSchoolDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PFmyschool.Models.Escuelas", b =>
                {
                    b.Property<int>("PkEscuela")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescEscuela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkNivel")
                        .HasColumnType("int");

                    b.Property<int>("FkSostenimiento")
                        .HasColumnType("int");

                    b.Property<int>("FkUbicaion")
                        .HasColumnType("int");

                    b.Property<string>("ImagEscuela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkEscuela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomEscuela")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PuntEscuela")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UbicacionPkUbicacion")
                        .HasColumnType("int");

                    b.HasKey("PkEscuela");

                    b.HasIndex("FkNivel");

                    b.HasIndex("FkSostenimiento");

                    b.HasIndex("UbicacionPkUbicacion");

                    b.ToTable("Escuelas");
                });

            modelBuilder.Entity("PFmyschool.Models.Localidad", b =>
                {
                    b.Property<int>("PkLocalidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomLocalidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkLocalidad");

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("PFmyschool.Models.Nivel", b =>
                {
                    b.Property<int>("PkNivel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomNivel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkNivel");

                    b.ToTable("Nivel");
                });

            modelBuilder.Entity("PFmyschool.Models.OfertasEdu", b =>
                {
                    b.Property<int>("PkOfertasEdu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescOferta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EscuelasPkEscuela")
                        .HasColumnType("int");

                    b.Property<int>("FkEscuela")
                        .HasColumnType("int");

                    b.Property<string>("NomOferta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkOfertasEdu");

                    b.HasIndex("EscuelasPkEscuela");

                    b.ToTable("OfertasEdu");
                });

            modelBuilder.Entity("PFmyschool.Models.Rol", b =>
                {
                    b.Property<int>("PkRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkRol");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("PFmyschool.Models.Sostenimiento", b =>
                {
                    b.Property<int>("PkSostenimiento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomSostenimiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkSostenimiento");

                    b.ToTable("Sostenimiento");
                });

            modelBuilder.Entity("PFmyschool.Models.Ubicacion", b =>
                {
                    b.Property<int>("PkUbicacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FkLocalidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreUbi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkUbicacion");

                    b.HasIndex("FkLocalidad");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("PFmyschool.Models.Usuario", b =>
                {
                    b.Property<int>("PkUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorreoUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FkRol")
                        .HasColumnType("int");

                    b.Property<string>("FotoperfUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkUsuario");

                    b.HasIndex("FkRol");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PFmyschool.Models.Escuelas", b =>
                {
                    b.HasOne("PFmyschool.Models.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("FkNivel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFmyschool.Models.Sostenimiento", "Sostenimiento")
                        .WithMany()
                        .HasForeignKey("FkSostenimiento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PFmyschool.Models.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("UbicacionPkUbicacion");

                    b.Navigation("Nivel");

                    b.Navigation("Sostenimiento");

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("PFmyschool.Models.OfertasEdu", b =>
                {
                    b.HasOne("PFmyschool.Models.Escuelas", "Escuelas")
                        .WithMany()
                        .HasForeignKey("EscuelasPkEscuela");

                    b.Navigation("Escuelas");
                });

            modelBuilder.Entity("PFmyschool.Models.Ubicacion", b =>
                {
                    b.HasOne("PFmyschool.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("FkLocalidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("PFmyschool.Models.Usuario", b =>
                {
                    b.HasOne("PFmyschool.Models.Rol", "Roles")
                        .WithMany()
                        .HasForeignKey("FkRol");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
