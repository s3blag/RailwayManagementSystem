using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                                 $"'{customerData.name}', '{customerData.surname}'," +
                                 $"'{customerData.address}', '{customerData.city}', '{customerData.zipCode}'," +
                                 $"'{customerData.phoneNumber}', '{customerData.email}'";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
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
