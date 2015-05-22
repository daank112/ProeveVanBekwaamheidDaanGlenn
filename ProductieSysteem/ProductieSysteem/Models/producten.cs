namespace ProductieSysteem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_.producten")]
    public partial class producten
    {
        [Key]
        public int productNr { get; set; }

        [Required]
        [StringLength(255)]
        public string productType { get; set; }
    
       public class products
        {
            [DisplayName("Deze week")]
            public string weekNummer { get; set; }

            [DisplayName("CurrentWeek")]
            [DataType(DataType.Date)]

            public DataType? Birth { get; set; }
            public DagenInWeek dageninweek { get; set; }
        }

       public enum DagenInWeek
            {
                Maandag = 1,
                Dinsdag = 2,
                Woensdag = 3,
                Donderdag = 4,
                Vrijdag = 5,
                Zaterdag = 6,
                Zondag = 7,

            }

    }
}
