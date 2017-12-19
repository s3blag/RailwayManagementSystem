using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Visits
    {
        public struct VisitData
        {
            public readonly string station_id,
                                   course_id,
                                   visit_order,
                                   avaible_seats,
                                   date;

            public VisitData(string station_id, string course_id, string visit_order, string avaible_seats, string date)
            {
                this.station_id = station_id;
                this.course_id = course_id;
                this.visit_order = visit_order;
                this.avaible_seats = avaible_seats;
                this.date = date;
            }
        }

        public static bool AddNewVisit(SqlConnection sqlConnection, VisitData visitData)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_VISIT " +
                                 $"'{visitData.station_id}', '{visitData.course_id}'," +
                                 $"'{visitData.visit_order}', '{visitData.avaible_seats}', '{visitData.date}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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

                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT ID FROM VISITS WHERE COURSE_ID = {courseId} AND VISIT_ORDER = {visitOrder}", sqlConnection))
                {
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
