using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_Home_Work_1.Deleters
{
    abstract class Deleter : BaseItem
    {
        public abstract string GetTable();
        public abstract string GetId();
        public void Delete()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.ConnectionString = conString;
                    sqlConnection.Open();

                    var command = sqlConnection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = $" DELETE FROM {GetTable()} WHERE Id = {GetId()}";


                    var count = command.ExecuteNonQuery();
                    if (count > 0)
                    {
                        Console.WriteLine($"{count}");
                    }
                    else if (count == 0)
                    {
                        Console.WriteLine($"No delete");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
