using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Stations
    {
        public static DataTable GetAllStations(SqlConnection sqlConnection)
        {
            try
            {
                using (var sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM STATIONS", sqlConnection))
                {
                    var dataTable = new DataTable();
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

        public static bool AddStation(SqlConnection sqlConnection, string name)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_STATION " +
                                 $"@name";
                var sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", name);
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
    }
}
