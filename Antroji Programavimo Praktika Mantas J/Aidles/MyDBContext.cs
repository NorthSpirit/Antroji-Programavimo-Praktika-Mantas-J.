using Antroji_Programavimo_Praktika_Mantas_J_.Grupes;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.Vartotojas.Vartotojas;
using Antroji_Programavimo_Praktika_Mantas_J_.MokejimaiPaslaugos;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.EntityFrameworkCore.Extensions;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Antroji_Programavimo_Praktika_Mantas_J_.Aidles
    {
    public class MyDBContext : DbContext
    {
        string serverName = "localhost";
        string databaseName = "kursinio";
        string user = "root";
        string password = "4124Mantas";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql($"server={serverName};database={databaseName};user={user};password={password};",
                new MySqlServerVersion(new Version(8, 0, 39)));
        }

        //Klases
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Naudotojams
                
            modelBuilder.Entity<Naudotojas>()
            .HasKey(n => n.naud_ID);

            modelBuilder.Entity<Naudotojas>()
            .HasDiscriminator<string>("naud_tipas")
            .HasValue<Gyventojas>("Gyventojas")
            .HasValue<Vadybininkas>("Vadybininkas")
            .HasValue<Administratorius>("Administratorius");

            modelBuilder.Entity<Gyventojas>()
            .HasOne(n => n.VartotojuGrupe)
            .WithMany()
            .HasForeignKey(n => n.gyv_vartGID);

            modelBuilder.Entity<Gyventojas>()
                .Property(n=> n.gyv_permoka)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Vadybininkas>()
           .HasOne(n => n.VartotojuGrupe)
           .WithMany()
           .HasForeignKey(n => n.vady_vartGID);

            //Paslaugoms
            modelBuilder.Entity<Paslauga>()
            .HasKey(n => n.pasl_ID);
            modelBuilder.Entity<Paslauga>()
           .HasOne(n => n.VartotojuGrupe)
           .WithMany()
           .HasForeignKey(n => n.pasl_vartGID);

            //Mokejimams
            modelBuilder.Entity<Mokejimas>()
            .HasKey(n => n.mok_ID);

            modelBuilder.Entity<Mokejimas>()
           .HasOne(n => n.Gyventojas)
           .WithMany()
           .HasForeignKey(n => n.mok_vartotojoID);

            modelBuilder.Entity<Mokejimas>()
            .Property(n => n.mok_pilnaKaina)
            .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Mokejimas>()
            .Property(n => n.mok_likutis)
            .HasColumnType("decimal(18,2)");

            //Vartotoju Grupems
            modelBuilder.Entity<VartotojuGrupe>()
            .HasKey(n => n.VartG_ID);

        }
        //Naudotojai
        public DbSet<Naudotojas> Naudotojai { get; set; }

        //Mokejimai ir paslaugos
        public DbSet<Mokejimas> Mokejimai { get; set; }
        public DbSet<Paslauga> Paslaugos { get; set; }
        //Grupes
        public DbSet<VartotojuGrupe> vartotojuGrupes { get; set; }

    }
}
