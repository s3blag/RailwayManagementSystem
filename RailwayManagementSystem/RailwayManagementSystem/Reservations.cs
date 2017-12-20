using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Reservations
    {
        public static bool AddReservations(SqlConnection sqlConnection, string customerId, string price, string courseId, string stationA, string stationB, string seatNumber)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_RESERVATIONS " +
                                 $"{customerId}, {price}, {courseId}, '{stationA}', '{stationB}', {seatNumber}";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
