using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ProductieSysteem1.Models
{
    public class Categorie
    {
        [Key]
        public int Cat_id { get; set; }
        public int Product_id { get; set; }
        public int StartGewicht { get; set; }
        public int EindGewicht { get; set; }
    }
    public class CatDBContext : DbContext  
    {
        public DbSet<Categorie> Categorien { get; set; }
    }
}