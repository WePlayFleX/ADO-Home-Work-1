using cs = System.Console;
using System.Data.Common;

namespace ADO_Home_Work_1.Selecters
{
    class ProductListSelecterLessCalory : Selecter
    {
        public ProductListSelecterLessCalory(int calory)
        {
            Calory = calory;
        }

        public int Calory { get; }

        public override string GenereteQuerySelect()
        {
            return $"SELECT * FROM ProductList WHERE Calory < {Calory}";
        }

        public override void Print(DbDataReader reader)
        {
            cs.WriteLine("Id:\tName:\t\tIsVegatable:\tColor:\t\tCalory:");

            while (reader.Read())
            {
                var Id = reader.GetInt32(0);
                var Name = reader.GetString(1);
                var IsVegatable = reader.GetBoolean(2);
                var Color = reader.GetString(3);
                var Calory = reader.GetInt32(4);

                cs.WriteLine($"{Id}\t{Name}{IsVegatable}\t{Color}\t{Calory}");
            }
        }
    }
}
