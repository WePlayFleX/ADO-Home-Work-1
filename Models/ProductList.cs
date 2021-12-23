using System.Data.Common;

namespace ADO_Home_Work_1.Models
{
    public class ProductList
    {
        private string type;
        private string color;

        public ProductList(int id, string name, string type, string color, int calories)
        {
            Id = id;
            Name = name;
            this.type = type;
            this.color = color;
            Calories = calories;
        }

        public enum ProductType { FRUIT, VEGETABLE }
        public enum ColorType { GREEN, YELLOW, RED, WHITE, VIOLET, ORANGE }

        internal int Id { get; }
        internal string Name { get; }
        internal ProductType Type { get; }
        internal ColorType Color { get; }
        internal int Calories { get; }

        public static ProductList GetProductListFromReader(DbDataReader sqlDataReader)
        {
            var id = sqlDataReader.GetInt32(0);
            var name = sqlDataReader.GetString(1);
            var type = sqlDataReader.GetString(2);
            var color = sqlDataReader.GetString(3);
            var calories = sqlDataReader.GetInt32(4);
            return new ProductList(id, name, type, color, calories);
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Type}\t{Color}\t{Calories}";
        }
    }
}
