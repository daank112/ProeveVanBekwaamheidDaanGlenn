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
        public string id { get; set; }

        [Required]
        [Display(Name = "User name")]
        public string gebruikersnaam { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string wachtwoord { get; set; }
 
        [Display(Name = "Remember on this computer")]
        public bool OnthoudMij { get; set; }
        
        /// <summary>
        /// Checks if user with given password exists in the database
        /// </summary>
        /// <param name="_username">User name</param>
        /// <param name="_password">User password</param>
        /// <returns>True if user exist and password is correct</returns>
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