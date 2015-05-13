using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductieSysteem.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Dashboard> Dashboard { get; set; }
    }
}