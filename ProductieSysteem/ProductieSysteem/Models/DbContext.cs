namespace ProductieSysteem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DefaultConnection : DbContext
    {
        public DefaultConnection()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<g_regel> g_regel { get; set; }
        public virtual DbSet<gebruikers> gebruikers { get; set; }
        public virtual DbSet<gebruikersType> gebruikersType { get; set; }
        public virtual DbSet<login> login { get; set; }
        public virtual DbSet<producten> producten { get; set; }
        public virtual DbSet<weekproductie> weekproductie { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gebruikers>()
                .Property(e => e.voornaam)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.achternaam)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.bedrijfsnaam)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.plaats)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.postcode)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikers>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<gebruikersType>()
                .Property(e => e.gebruikersType1)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.gebruikersnaam)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.wachtwoord)
                .IsUnicode(false);

            modelBuilder.Entity<producten>()
                .Property(e => e.productType)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.maandag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.dinsdag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.woensdag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.donderdag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.vrijdag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.zaterdag)
                .IsUnicode(false);

            modelBuilder.Entity<weekproductie>()
                .Property(e => e.zondag)
                .IsUnicode(false);
        }
    }
}
