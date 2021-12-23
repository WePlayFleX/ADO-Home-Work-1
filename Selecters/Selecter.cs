using cs = System.Console;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System;

namespace ADO_Home_Work_1.Selecters
{
    abstract class Selecter : BaseItem
    {
        public abstract string GenereteQuerySelect();
        public abstract void Print(DbDataReader reader);
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
                    Print(sqlReader);
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
