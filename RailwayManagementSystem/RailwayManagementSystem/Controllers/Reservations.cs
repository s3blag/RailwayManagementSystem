using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Reservations
    {
        public static bool AddReservations(SqlConnection sqlConnection, string customerId, 
                            string price, string courseId, string stationA, string stationB, string seatNumber)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_RESERVATIONS " +
                                 $"@customerID, @price, @courseID, @stationA, @stationB, @seatNumber";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@customerID", customerId);
                sqlCommand.Parameters.AddWithValue("@price", price);
                sqlCommand.Parameters.AddWithValue("@courseID", courseId);
                sqlCommand.Parameters.AddWithValue("@stationA", stationA);
                sqlCommand.Parameters.AddWithValue("@stationB", stationB);
                sqlCommand.Parameters.AddWithValue("@seatNumber", seatNumber);
                sqlCommand.ExecuteNonQuery();

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
            return true;
        }

        public static DataTable GetCustomerReservations(SqlConnection sqlConnection, string customerID)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC SHOW_CUSTOMER_RESERVATION @customerID", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@customerID", customerID);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    if (dataTable.Rows.Count != 0)
                        return dataTable;
                    else
                        return null;
                }
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
                return null;
            }

        }
    }
}
