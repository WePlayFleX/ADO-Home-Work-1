using cs = System.Console;
using ADO_Home_Work_1.Inserters;
using ADO_Home_Work_1.Selecters;
using ADO_Home_Work_1.Deleters;
using ADO_Home_Work_1.Functions;

namespace ADO_Home_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserter inserterProductsList =
            //     new ProductsListInserter(1, "Apple", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.GREEN, 52);
            //new ProductsListInserter(2, "Banana", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.YELLOW, 89);
            //new ProductsListInserter(3, "Tomato", ProductsListInserter.ProductType.VEGETABLE, ProductsListInserter.ColorType.RED, 52);
            //new ProductsListInserter(4, "Onion", ProductsListInserter.ProductType.VEGETABLE, ProductsListInserter.ColorType.WHITE, 40);
            //new ProductsListInserter(5, "Grape", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.VIOLET, 67);
            //new ProductsListInserter(6, "Carrot", ProductsListInserter.ProductType.VEGETABLE, ProductsListInserter.ColorType.ORANGE, 35);
            //new ProductsListInserter(7, "Garnet", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.RED, 83);
            //new ProductsListInserter(8, "Cucumber", ProductsListInserter.ProductType.VEGETABLE, ProductsListInserter.ColorType.GREEN, 16);
            //new ProductsListInserter(9, "Lemon", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.YELLOW, 29);
            //new ProductsListInserter(10, "Potato", ProductsListInserter.ProductType.VEGETABLE, ProductsListInserter.ColorType.YELLOW, 77);
            //new ProductsListInserter(11, "Kiwi", ProductsListInserter.ProductType.FRUIT, ProductsListInserter.ColorType.GREEN, 61);

            //inserterProductsList.Insert();


            //ProductListSelecter productListSelecter = new ProductListSelecter();
            //productListSelecter.Select();

            //var selecter = new NameSelecter();
            //selector.Select();

            //var selecter = new ColorSelecter();
            //selecter.Select();

            //var functionSelecter = new MaxCalorySelecter();
            //functionSelecter.Select();

            //var functionSelecter = new MinCalorySelecter();
            //functionSelecter.Select();

            //var functionSelecter = new AvgCalorySelecter();
            //functionSelecter.Select();

            //var functionSelecter = new VegatableCountSelecter();
            //functionSelecter.Select();

            //var functionSelecter = new FruitCountSelecter();
            //functionSelecter.Select();

            //var functionSelecter = new NumberSelecterWithColor("Red");
            //functionSelecter.Select();

            //var selecter = new ColorNumberSelector();
            //selecter.Select();

            //var selecter = new ProductListSelecterLessCalory(100);
            //selecter.Select();

            //var selecter = new ProductListSelecterMoreCalory(100);
            //selecter.Select();

            //var selecter = new ProductListSelecterInRange(50, 200);
            //selecter.Select();

            //var selecter = new ProductListSelecterYellowRed();
            //selecter.Select();


            //ProductListDeleter productListDeleter = new ProductListDeleter(1);
            //productListDeleter.Delete();

            cs.ReadKey();
        }
    }
}
