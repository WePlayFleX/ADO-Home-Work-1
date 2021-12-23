using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class VegatableCountSelecter : FunctionsSelecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT COUNT (*) FROM ProductList WHERE IS Vegatable = 1";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Number of vegatables: {num}");
        }
    }
}
