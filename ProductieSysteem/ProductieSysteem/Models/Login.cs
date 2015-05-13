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
        [Required]
        [Display(Name = "User name")]
        public string gebruikersnaam { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string wachtwoord { get; set; }

        [Display(Name = "Remeber me on this computer")]
        public bool RememberMe { get; set; }

        

       public bool IsValid(string _username, string _password)
        {
            DefaultConnection cn = new DefaultConnection();
            if (_username == gebruikersnaam || _password == wachtwoord)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            

             
            //using (var cn = new SqlConnection(@"Data Source=Data Source=h2437976.stratoserver.net;Initial Catalog=Productiesysteem;User ID=Daan;Password=Maaskantje_95"))
            //{
            //    string _sql = @"SELECT [gebruikersnaam] FROM [dbo].[tbl_login] " +
            //           @"WHERE [gebruikersnaam] = @u AND [wachtwoord] = @p";
            //    var cmd = new SqlCommand(_sql, cn);
            //    cmd.Parameters
            //        .Add(new SqlParameter("@u", SqlDbType.NVarChar))
            //        .Value = _username;
            //    cmd.Parameters
            //        .Add(new SqlParameter("@p", SqlDbType.NVarChar))
            //        .Value = Helpers.SHA1.Encode(_password);
            //    cn.Open();
            //    var reader = cmd.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        reader.Dispose();
            //        cmd.Dispose();
            //        return true;
            //    }
            //    else
            //    {
            //        reader.Dispose();
            //        cmd.Dispose();
            //        return false;
            //    }
            //}
           // return true;
        }
    }
}