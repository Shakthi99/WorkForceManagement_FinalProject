using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WfmManagementAPI.Models
{
    public class LoginRepository
    {
        public List<UserDetails> GetUserForLogin(LoginCriteria loginCriteria)
        {
            List<UserDetails> detail = new List<UserDetails>();
            using (var conn = new SqlConnection("Data Source=SQL201901.softura.com;User ID=ShakthiRM;Password=Shakthi@123;Initial Catalog=Shakth_TempDB;Connection Timeout=0"))
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 0;
                    command.CommandText = "sp_GetUserForLogin";
                    command.Parameters.AddWithValue("@UserName", loginCriteria.UserName);
                    command.Parameters.AddWithValue("@Password", loginCriteria.Password);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detail.Add(new UserDetails()
                            {
                                Username = reader.GetString("UserName"),
                                Password = reader.GetString("Password"),
                                FirstName = reader.GetString("FirstName"),
                                Role = reader.GetString("Role"),
                                Email = reader.GetString("Email")
                            });
                        }
                    }
                }
            }
            return detail;
        }
    }
}
