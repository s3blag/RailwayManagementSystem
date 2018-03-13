using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

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
                                 $"@courseID, @visitID, @numberOfSeats";
                var sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@courseID", courseId);
                sqlCommand.Parameters.AddWithValue("@visitID", visitId);
                sqlCommand.Parameters.AddWithValue("@numberOfSeats", numberOfSeats);
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

        public static int GetRandomSeat(SqlConnection sqlConnection, string courseID, string stationA, string stationB)
        {
            try
            {
                using (var sqlDataAdapter = new SqlDataAdapter($"EXEC SHOW_AVAIBLE_SEATS @courseID, @stationA, @stationB", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@courseID", courseID);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@stationA", stationA);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@stationB", stationB);
                    var dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count == 0)
                        return -1;
                    var rnd = new Random();
                    int seat = rnd.Next(dataTable.Rows.Count);
                    int seatIndex = Int32.Parse(dataTable.Rows[seat][0].ToString());
                    return seatIndex;
                }
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
                return -2;
            }
        }
    }
}
