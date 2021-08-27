﻿// <auto-generated />
using Academy.TestWeek5.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academy.TestWeek5.EF.Migrations
{
    [DbContext(typeof(PiattoContext))]
    partial class PiattoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy.TestWeek5.Core.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "1234",
                            Role = 1,
                            Username = "mrossi@abc.it"
                        },
                        new
                        {
                            Id = 2,
                            Password = "5678",
                            Role = 0,
                            Username = "mari@abc.it"
                        });
                });

            modelBuilder.Entity("Academy.TestWeek5.Core.Piatto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descrizione")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prezzo")
                        .HasColumnType("float");

                    b.Property<int>("Tipologia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Piatto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descrizione = "Lasagna con pesto",
                            Nome = "Lasagna al pesto",
                            Prezzo = 10.5,
                            Tipologia = 0
                        },
                        new
                        {
                            Id = 2,
                            Descrizione = "Aragosta con sugo",
                            Nome = "Aragosta al sugo",
                            Prezzo = 15.5,
                            Tipologia = 1
                        },
                        new
                        {
                            Id = 3,
                            Descrizione = "Patatine fritte",
                            Nome = "Patatine",
                            Prezzo = 7.5,
                            Tipologia = 2
                        },
                        new
                        {
                            Id = 4,
                            Descrizione = "biscotti savoiardi con crema al mascarpone caffè e cacao",
                            Nome = "Tiramisù",
                            Prezzo = 5.5,
                            Tipologia = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
