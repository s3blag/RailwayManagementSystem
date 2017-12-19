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
    }
}
