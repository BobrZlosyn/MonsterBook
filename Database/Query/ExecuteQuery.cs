using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Query
{
    public class ExecuteQuery
    {
        public void Execute(QueryLine sql, string demoXml, string connectionString)
        {
            // Update the demographics for a store, which is stored  
            // in an xml column.  
            string commandText = "UPDATE Sales.Store SET Demographics = @demographics "
                + "WHERE CustomerID = @ID;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(commandText, connection);
                /*command.Parameters.Add("@ID", SqlDbType.Int);
                command.Parameters["@ID"].Value = customerID;*/

                // Use AddWithValue to assign Demographics. 
                // SQL Server will implicitly convert strings into XML.
                command.Parameters.AddWithValue("@demographics", demoXml);

                try
                {
                    connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
