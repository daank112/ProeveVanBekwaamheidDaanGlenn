using System.Data.Entity;

namespace ProductieSysteem.Models
{
    public class DefaultConnection : DbContext 
    {
        //public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        //public virtual DbSet<tbl_g_regel> tbl_g_regel { get; set; }
        public virtual DbSet<Gebruikers> Gebruikers { get; set; }
        //public virtual DbSet<tbl_gebruikersType> tbl_gebruikersType { get; set; }
        public virtual DbSet<Login> tbl_login { get; set; }
        //public virtual DbSet<tbl_producten> tbl_producten { get; set; }
        //public virtual DbSet<tbl_weekproductie> tbl_weekproductie { get; set; }
    }
}