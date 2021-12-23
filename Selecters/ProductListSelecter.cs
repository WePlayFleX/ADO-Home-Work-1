using cs = System.Console;
using System.Data.Common;

namespace ADO_Home_Work_1.Selecters
{
    class ProductListSelecter : Selecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT * FROM ProductsList";
        }

        public override void Print(DbDataReader reader)
        {
            while (reader.Read())
            {
                var productList = GetProductListFromReader(reader);
                cs.WriteLine(productList);
            }
        }

        private static object GetProductListFromReader(DbDataReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}
