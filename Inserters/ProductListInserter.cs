using System.Data;
using System.Data.SqlClient;

namespace ADO_Home_Work_1.Inserters
{
    internal class ProductsListInserter : Inserter
    {
        public ProductsListInserter(int id, string name, ProductType type, ColorType color, int calories)
        {
            Id = id;
            Name = name;
            Type = type;
            Color = color;
            Calories = calories;
        }

        public enum ProductType { FRUIT, VEGETABLE }
        public enum ColorType { GREEN, YELLOW, RED, WHITE, VIOLET, ORANGE }

        internal int Id { get; }
        internal string Name { get; }
        internal ProductType Type { get; }
        internal ColorType Color { get; }
        internal int Calories { get; }

        public override void InitCommand(SqlCommand command)
        {
            command.CommandType = CommandType.Text;
            command.CommandText = $"INSERT INTO ProductsList (Id, Name, Type, Color, Calories) " +
                                    $"VALUES ({Id}, '{Name}', '{Type}', '{Color}', {Calories}) ";
        }
    }
}
