using cs = System.Console;
using System.Data.Common;

namespace ADO_Home_Work_1.Selecters
{
    class ColorSelecter : Selecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT Color FROM VegetablesAndFruits";
        }

        public override void Print(DbDataReader reader)
        {
            cs.WriteLine("Color:");

            while (reader.Read())
            {
                var Color = reader.GetString(0);

                cs.WriteLine($"{Color}");
            }
        }
    }
}
