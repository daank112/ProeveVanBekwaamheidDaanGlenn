using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace ProductieSysteem.Models
{
    public class Login
    {
        [Key]
        [Display(Name = "Id")]
        public int gebruikersId { get; set; }

        [Required]
        [Display(Name = "Gebruikersnaam")]
        public string gebruikersnaam { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Wachtwoord")]
        public string wachtwoord { get; set; }
 
        [Display(Name = "Onthoud mij op deze computer")]
        public bool OnthoudMij { get; set; }
        
        public bool IsValid(string _username, string _password)
        {
            DefaultConnection df = new DefaultConnection();
            var cn = new SqlConnection(df.Database.Connection.ConnectionString.ToString());
           
                string _sql = @"SELECT [gebruikersnaam] FROM [dbo].[tbl_login] " + 
                       @"WHERE [gebruikersnaam] = @u AND [wachtwoord] = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = _username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                    .Value = Helpers.SHA1.Encode(_password);
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            
        }
    }
}