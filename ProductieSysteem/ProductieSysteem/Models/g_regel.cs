namespace ProductieSysteem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_.g_regel")]
    public partial class g_regel
    {
        [Key]
        public int gebruikersId { get; set; }

        public int weekId { get; set; }

        public int weekproductie { get; set; }
    }
}
