using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Seats
    {
        public static void AddSeats(SqlConnection sqlConnection, string courseId, string visitId, int numberOfSeats)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_SEATS " +
                                 $"{courseId}, {visitId}, {numberOfSeats}";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
