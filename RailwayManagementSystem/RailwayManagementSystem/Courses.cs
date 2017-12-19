using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayManagementSystem
{
    internal static class Courses
    {
        public static DataTable GetCoursesFromAtoB(SqlConnection sqlConnection, string cityA, string cityB)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM SHOW_COURSES_WITH_AB('{cityA}', '{cityB}')", sqlConnection))
                {
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

        public static DataTable GetAllCourses(SqlConnection sqlConnection)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM SHOW_COURSES", sqlConnection))
                {
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

        public static DataTable GetCourseVisits(SqlConnection sqlConnection, string courseID)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC SHOW_COURSE_VISITS {courseID}", sqlConnection))
                {
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

        public static bool AddCourse(SqlConnection sqlConnection, int trainId)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_COURSE " +
                                 $"'{trainId}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                //Można się pobawić w informowanie, że dodano x wierszy, bo zwraca int
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
                return false;
            }
        }

        public static int GetNumberOfVisits(SqlConnection sqlConnection, string courseId)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM VISITS WHERE COURSE_ID = " + courseId, sqlConnection))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    return dataTable.Rows.Count;
                }
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
                return -1;
            }
        }

        public static bool DeleteCourse(SqlConnection sqlConnection, int courseId)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC DELETE_COURSE " +
                                 $"'{courseId}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return false;
            }
        }

    }
}
