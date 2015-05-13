using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductieSysteem.Models
{
    public class Categorie
    {
       
        public int Cat_id { get; set; }
        public int Product_id { get; set; }
        public int StartGewicht { get; set; }
        public int EindGewicht { get; set; }

                
    }
    public class CategorieDbContect : EFDbContext
    {
        public DbSet<Categorie> Categorie { get; set; }
    }
    
}