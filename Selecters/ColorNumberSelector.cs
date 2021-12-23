using cs = System.Console;
using System.Data.Common;

namespace ADO_Home_Work_1.Selecters
{
    class ColorNumberSelector : Selecter
    {
        public override string GenereteQuerySelect()
        {
            return @"SELECT Color, COUNT(*) FROM ProductsList
                    Where Color IN (SELECT Color FROM ProductsList)
                    GROUP BY Color";
        }

        public override void Print(DbDataReader reader)
        {
            cs.WriteLine("Color:\t\tCount:");

            while (reader.Read())
            {
                var Color = reader.GetString(0);
                var Count = reader.GetInt32(1);

                cs.WriteLine($"{Color}\t{Count}");
            }
        }
    }
}
