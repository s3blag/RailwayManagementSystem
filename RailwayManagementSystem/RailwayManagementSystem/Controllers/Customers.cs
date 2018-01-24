using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RailwayManagementSystem
{
    internal static class Customers
    {
        public struct CustomerData
        {
            public readonly string name, 
                                   surname,
                                   address,
                                   city, 
                                   zipCode,
                                   phoneNumber,
                                   email;

            public CustomerData(string name, string surname, string address, string city, string zipCode, string phoneNumber, string email)
            {
                this.name = name;
                this.surname = surname;
                this.address = address;
                this.city = city;
                this.zipCode = zipCode;
                this.phoneNumber = phoneNumber;
                this.email = email;
            }
        }

        public static DataTable GetAllCustomers(SqlConnection sqlConnection)
        {   
            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Show_Customers", sqlConnection))
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

        public static bool AddNewCustomer(SqlConnection sqlConnection, CustomerData customerData)
        {
            try
            {
                sqlConnection.Open();
                string command = $"EXEC CREATE_NEWCUSTOMER " +
                                 $"@name, @surname," +
                                 $"@address, @city, @zipCode," +
                                 $"@phoneNumber, @email";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@name", customerData.name);
                sqlCommand.Parameters.AddWithValue("@surname", customerData.surname);
                sqlCommand.Parameters.AddWithValue("@address", customerData.address);
                sqlCommand.Parameters.AddWithValue("@city", customerData.city);
                sqlCommand.Parameters.AddWithValue("@zipCode", customerData.zipCode);
                sqlCommand.Parameters.AddWithValue("@phoneNumber", customerData.phoneNumber);
                sqlCommand.Parameters.AddWithValue("@email", customerData.email);
                //Można się pobawić w informowanie, że dodano x wierszy, bo zwraca int
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
