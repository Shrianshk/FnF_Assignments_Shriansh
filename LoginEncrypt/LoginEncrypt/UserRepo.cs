using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LoginEncrypt
{
    public class UserRepo
    {
         string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionConfig"].ConnectionString;

       
        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserDetails (Username, hashpassword) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", user.UserName);
                cmd.Parameters.AddWithValue("@Password", EncryptionHelper.HashPassword(user.HashPassword));

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM UserDetails WHERE Username = @Username AND hashpassword = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", EncryptionHelper.HashPassword(password));

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


    }
}