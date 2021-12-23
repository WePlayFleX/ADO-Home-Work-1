using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class AvgCalorySelecter : FunctionsSelecter
    {
        public override string GenereteQuerySelect()
        {
            return "SELECT AVG(Calory) FROM ProductList";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Average calory: {num}");
        }
    }
}
