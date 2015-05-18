namespace ProductieSysteem.Models
    {
        using System;
        using System.Data.Entity;
        using System.Data.Entity.Infrastructure;

        public partial class DefaultConnection : DbContext
        {

          

            //public virtual DbSet<tbl_g_regel> tbl_g_regel { get; set; }
            //public virtual DbSet<Gebruikers> tbl_gebruikers1 { get; set; }
            public virtual DbSet<tbl_gebruikers> tbl_gebruikers { get; set; }
            //public virtual DbSet<tbl_gebruikersType> tbl_gebruikersType { get; set; }
            public virtual DbSet<Login> tbl_login { get; set; }
            //public virtual DbSet<tbl_producten> tbl_producten { get; set; }
            //public virtual DbSet<tbl_weekproductie> tbl_weekproductie { get; set; }
        }
    }
