using System;
using cs = System.Console;
using System.Data.SqlClient;

namespace ADO_Home_Work_1.Inserters
{
    internal abstract class Inserter : BaseItem
    {
        public abstract void InitCommand(SqlCommand command);

        internal void Insert()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.ConnectionString = conString;
                    try
                    {
                        sqlConnection.Open();
                        cs.WriteLine("Successful connection!");
                    }
                    catch (Exception e)
                    {
                        cs.WriteLine("Connection error! " + e.Message);
                    }

                    var command = sqlConnection.CreateCommand();
                    InitCommand(command);
                    var count = command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        cs.WriteLine("Ok!\nNumber of lines changed: " + count);
                    }
                }
                catch (Exception e)
                {
                    cs.WriteLine(e.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
