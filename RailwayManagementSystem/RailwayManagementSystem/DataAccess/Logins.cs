using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayManagementSystem
{
    public static class Logins
    {
        public static bool? Validate(string login, string password, SqlConnection sqlConnection)
        {
            try
            {
                var cmd = new SqlCommand("SELECT COUNT (*) FROM LOGINS WHERE LOGIN=@usr AND PASSWORD=@pwd", sqlConnection);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usr", login);
                cmd.Parameters.AddWithValue("@pwd", password);
                sqlConnection.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    return true;
                else
                    return false;
            }
            catch
            {
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
