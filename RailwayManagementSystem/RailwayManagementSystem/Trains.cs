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
    internal static class Trains
    {
        public static DataTable GetAllTrains(SqlConnection sqlConnection)
        {
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Show_Trains", sqlConnection))
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

        public static void AddTrain(SqlConnection sqlConnection, string name, string model)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC ADD_TRAIN " +
                                 $"'{name}', '{model}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                //Można się pobawić w informowanie, że dodano x wierszy, bo zwraca int
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                Debug.WriteLine("Błąd zapytania do bazy danych!");
            }
        }
    }
}
