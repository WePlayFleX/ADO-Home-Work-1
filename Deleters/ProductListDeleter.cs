namespace ADO_Home_Work_1.Deleters
{
    class ProductListDeleter : Deleter
    {
        public ProductListDeleter(int id)
        {
            Id = id;
        }

        int Id { get; }
        public override string GetId() => Id.ToString();
        public override string GetTable() => "ProductsList";
    }
}
