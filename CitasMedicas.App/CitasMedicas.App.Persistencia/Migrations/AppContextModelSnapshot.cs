﻿// <auto-generated />
using System;
using CitasMedicas.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CitasMedicas.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CitasMedicas.App.Dominio.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaCita")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.Property<string>("Nota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("SedeId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaNacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SedeId")
                        .HasColumnType("int");

                    b.Property<bool>("TieneEps")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("SedeId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Sede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("NombreSede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Medico", b =>
                {
                    b.HasBaseType("CitasMedicas.App.Dominio.Persona");

                    b.Property<string>("Agenda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Medico_Ciudad");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especializacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistroMedico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMedico")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Medico");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Paciente", b =>
                {
                    b.HasBaseType("CitasMedicas.App.Dominio.Persona");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MedicoId")
                        .HasColumnType("int");

                    b.HasIndex("MedicoId");

                    b.HasDiscriminator().HasValue("Paciente");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Agenda", b =>
                {
                    b.HasOne("CitasMedicas.App.Dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.HasOne("CitasMedicas.App.Dominio.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId");

                    b.HasOne("CitasMedicas.App.Dominio.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Persona", b =>
                {
                    b.HasOne("CitasMedicas.App.Dominio.Sede", "Sede")
                        .WithMany()
                        .HasForeignKey("SedeId");

                    b.Navigation("Sede");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Sede", b =>
                {
                    b.HasOne("CitasMedicas.App.Dominio.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId");

                    b.Navigation("Ciudad");
                });

            modelBuilder.Entity("CitasMedicas.App.Dominio.Paciente", b =>
                {
                    b.HasOne("CitasMedicas.App.Dominio.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId");

                    b.Navigation("Medico");
                });
#pragma warning restore 612, 618
        }
    }
}
