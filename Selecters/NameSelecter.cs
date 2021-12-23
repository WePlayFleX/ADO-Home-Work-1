using cs = System.Console;
using System.Data.Common;

namespace ADO_Home_Work_1.Selecters
{
    class NameSelecter : Selecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT Name FROM ProductList";
        }

        public override void Print(DbDataReader reader)
        {
            cs.WriteLine("Name:");

            while (reader.Read())
            {
                var Name = reader.GetString(0);

                cs.WriteLine($"{Name}");
            }
        }
    }
}
