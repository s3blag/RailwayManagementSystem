using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Visits
    {
        public struct VisitData
        {
            public readonly string stationID,
                                   courseID,
                                   visitOrder,
                                   avaibleSeats,
                                   date;

            public VisitData(string station_id, string courseID, string visitOrder, string avaibleSeats, string date)
            {
                this.stationID = station_id;
                this.courseID = courseID;
                this.visitOrder = visitOrder;
                this.avaibleSeats = avaibleSeats;
                this.date = date;
            }
        }

        public static bool AddNewVisit(SqlConnection sqlConnection, VisitData visitData)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_VISIT " +
                                 $"@stationID, @courseID," +
                                 $"@visitOrder, @availableSeats, @date";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@stationID", visitData.stationID);
                sqlCommand.Parameters.AddWithValue("@courseID", visitData.courseID);
                sqlCommand.Parameters.AddWithValue("@visitOrder", visitData.visitOrder);
                sqlCommand.Parameters.AddWithValue("@availableSeats", visitData.avaibleSeats);
                sqlCommand.Parameters.AddWithValue("@date", visitData.date);
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

        public static string GetVisitId(SqlConnection sqlConnection, string courseId, string visitOrder)
        {
            try
            {

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(
                    $"SELECT ID FROM VISITS WHERE COURSE_ID = @courseID AND VISIT_ORDER = @visitOrder", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@courseID", courseId);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@visitOrder", visitOrder);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    string test = dataTable.Rows[0][0].ToString();
                    return dataTable.Rows[0][0].ToString();
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
