using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_1_csvToText
{
    static class DBUtil
    {
        internal static void InsertData(string connectionString, string result)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    Console.WriteLine("Connection state : " + connection.State);
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = connection;
                    sqlCmd.CommandText = @"INSERT INTO DGP2 (test) VALUES('" + result + "')";
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
