using cs = System.Console;
using System.Data;
using System.Data.SqlClient;
using System;

namespace ADO_Home_Work_1.Functions
{
    abstract class FunctionsSelecter : BaseItem
    {
        public abstract string GenereteQuerySelect();
        public abstract void PrintScalarRes(object num);
        public void Select()
        {
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                try
                {
                    sqlConnection.ConnectionString = conString;
                    sqlConnection.Open();

                    var command = sqlConnection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = GenereteQuerySelect();
                    var sqlReader = command.ExecuteReader();
                    PrintScalarRes(sqlReader);
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
