using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductieSysteem.Models
{
    public class Gebruikers
    {
        public int gebruikersId { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string bedrijfsnaam { get; set; }
        public string adres { get; set; }
        public string plaats { get; set; }
        public string postcode { get; set; }
        public string email { get; set; }
        public Nullable<int> gebruikersType { get; set; }
       
    }
    
}