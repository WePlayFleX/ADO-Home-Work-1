using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class FruitCountSelecter : FunctionsSelecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT COUNT (*) FROM ProductList WHERE IS Vegatable = 0";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Number of Fruits: {num}");
        }
    }
}
