namespace ProductieSysteem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_.gebruikersType")]
    public partial class gebruikersType
    {
        [Key]
        public int typeNr { get; set; }

        [Column("gebruikersType")]
        [Required]
        [StringLength(255)]
        public string gebruikersType1 { get; set; }
    }
}
