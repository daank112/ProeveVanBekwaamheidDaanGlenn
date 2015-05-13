using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductieSysteem.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Data.Entity;

namespace ProductieSysteem.Models
{
    public class Dashboard
    {
        [DisplayName("DezeWeek")]

        public string WeekNummer { get; set; }


        [DisplayName("CurrentWeek")]
        [DataType(DataType.Date)]
      
        
        public DateTime? Birth { get; set; }
        public DagenInWeek dagenInWeek { get; set; }


    }
    public enum DagenInWeek
    {
        Maandag = 1, 
        Dinsdag = 2, 
        Woensdag = 3, 
        Donderdag = 4, 
        Vrijdag = 5, 
        Zaterdag = 6, 
        Zondag = 7
        
    }
    
}