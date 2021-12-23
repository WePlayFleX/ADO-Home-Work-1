using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class MinCalorySelecter : FunctionsSelecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT MIN (Calory) FROM ProductList";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Min Calory: {num}");
        }
    }
}
