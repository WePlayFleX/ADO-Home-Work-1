using cs = System.Console;

namespace ADO_Home_Work_1.Functions
{
    class NumberSelecterWithColor : FunctionsSelecter
    {
        public NumberSelecterWithColor(string color)
        {
            Color = color;
        }

        public string Color { get; }

        public override string GenereteQuerySelect()
        {
            return $"SELECT COUNT (*) FROM ProductList WHERE Color = '{Color}'";
        }

        public override void PrintScalarRes(object num)
        {
            cs.WriteLine($"Number of products with {Color} color: {num}");
        }
    }
}
