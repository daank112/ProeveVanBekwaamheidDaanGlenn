namespace ProductieSysteem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_.gebruikers")]
    public partial class gebruikers
    {
        public int gebruikersId { get; set; }

        [StringLength(255)]
        public string voornaam { get; set; }

        [StringLength(255)]
        public string achternaam { get; set; }

        [StringLength(255)]
        public string bedrijfsnaam { get; set; }

        [StringLength(255)]
        public string adres { get; set; }

        [StringLength(255)]
        public string plaats { get; set; }

        [StringLength(255)]
        public string postcode { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public int? gebruikersType { get; set; }
    }
}
