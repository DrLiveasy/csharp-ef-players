﻿// <auto-generated />
using CSharp_Entity_Framework_Players;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    [DbContext(typeof(CalcioContext))]
    [Migration("20221222153319_AltraModificaPerLeColonne")]
    partial class AltraModificaPerLeColonne
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CSharp_Entity_Framework_Players.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayerId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<double>("Punteggio")
                        .HasColumnType("float")
                        .HasColumnName("punteggio");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cognome");

                    b.Property<int>("partiteGiocate")
                        .HasColumnType("int")
                        .HasColumnName("partite_giocate");

                    b.Property<int>("partiteVinte")
                        .HasColumnType("int")
                        .HasColumnName("partite_vinte");

                    b.HasKey("PlayerId");

                    b.ToTable("players");
                });

            modelBuilder.Entity("CSharp_Entity_Framework_Players.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cognome");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<string>("Trainer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("allenatore");

                    b.HasKey("TeamId");

                    b.ToTable("teams");
                });
#pragma warning restore 612, 618
        }
    }
}
