namespace ProductieSysteem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;
    using System.Data.SqlClient;
    using System.Security.Cryptography;
    using System.Text;

    [Table("tbl_.login")]
    public partial class login
    {
        [Key]
        public int gebruikersId { get; set; }

        [Required]
        [StringLength(255)]
        public string gebruikersnaam { get; set; }

        [StringLength(255)]
        public string wachtwoord { get; set; }

        public string PasswordHash(string _password)
        {
            var jan = Helpers.SHA1.Encode(_password);
            return jan.ToString();
            //SHA1 sha1 = SHA1.Create();
            //byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(_password));
            //StringBuilder returnValue = new StringBuilder();

            //for (int i = 0; i < hashData.Length; i++)
            //{
            //    returnValue.Append(hashData[i].ToString());
            //}

            //return returnValue.ToString();

        }
        
        public bool IsValid(string _username, string _password)
        {
            DefaultConnection df = new DefaultConnection();
            var cn = new SqlConnection(df.Database.Connection.ConnectionString.ToString());

            string _sql = @"SELECT [gebruikersnaam] FROM [tbl_].[login] " +
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
