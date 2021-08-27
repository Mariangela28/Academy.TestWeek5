using Academy.TestWeek5.Core;
using Academy.TestWeek5.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Academy.TestWeek5.EF
{
    public class PiattoContext : DbContext
    {
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public PiattoContext(DbContextOptions<PiattoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Piatto>().ToTable("Piatto")
                                           .HasKey(k => k.Id);
            modelBuilder.Entity<Piatto>().Property(n => n.Nome).IsRequired();
            modelBuilder.Entity<Piatto>().Property(d => d.Descrizione).IsRequired();
            modelBuilder.Entity<Piatto>().Property(t => t.Tipologia).IsRequired();
            modelBuilder.Entity<Piatto>().Property(p => p.Prezzo).IsRequired();

            modelBuilder.Entity<Account>().ToTable("Users").HasKey(k => k.Id);
            modelBuilder.Entity<Account>().Property(u => u.Username).IsRequired();
           
            modelBuilder.Entity<Account>().Property(p => p.Password).IsRequired();
            modelBuilder.Entity<Account>().Property(r => r.Role).IsRequired();

            modelBuilder.Entity<Account>().HasData(
                new Account { Id = 1, Username = "mrossi@abc.it", Password = "1234", Role = Role.Cliente },
                new Account { Id = 2, Username = "mari@abc.it", Password = "5678", Role = Role.Ristoratore }
            );
            modelBuilder.Entity<Piatto>().HasData(
                new Piatto
                {
                    Id = 1,
                    Nome = "Lasagna al pesto",
                    Descrizione = "Lasagna con pesto",
                    Tipologia = Tipologia.Primo,
                    Prezzo = 10.50

                },
               
            new Piatto
            {
                Id = 2,
                Nome = "Aragosta al sugo",
                Descrizione = "Aragosta con sugo",
                Tipologia = Tipologia.Secondo,
                Prezzo = 15.50

            },
            new Piatto
            {
                Id = 3,
                Nome = "Patatine",
                Descrizione = "Patatine fritte",
                Tipologia = Tipologia.Contorno,
                Prezzo = 7.50,

            },
            new Piatto
            {
                Id = 4,
                Nome = "Tiramisù",
                Descrizione = "biscotti savoiardi con crema al mascarpone caffè e cacao",
                Tipologia = Tipologia.Dolce,
                Prezzo = 5.50,

            }
                
            );

        }
    }
}
