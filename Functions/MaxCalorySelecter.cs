using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class MaxCalorySelecter : FunctionsSelecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT MAX (Calory) FROM ProductList";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Max Calory: {num}");
        }
    }
}

