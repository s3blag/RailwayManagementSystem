using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Courses
    {

        public static DataTable GetAvaibleCoursesFromAtoB(SqlConnection sqlConnection, string cityA, string cityB)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC SHOW_AVAIBLE_COURSES @cityA, @cityB ", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cityA", cityA);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cityB", cityB);
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

        public static DataTable GetCoursesFromAtoB(SqlConnection sqlConnection, string cityA, string cityB)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM SHOW_COURSES_WITH_AB(@cityA, @cityB)", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cityA", cityA);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cityB", cityB);
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
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC SHOW_COURSE_VISITS @courseID", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@courseID", courseID);
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
                                 $"@trainID";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@trainID", trainId);
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

        public static int GetNumberOfVisits(SqlConnection sqlConnection, string courseId)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM VISITS WHERE COURSE_ID = @courseID", sqlConnection))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@courseID", courseId);
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
                                 $"@courseID";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@courseID", courseId);
                sqlCommand.ExecuteNonQuery();   
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
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
