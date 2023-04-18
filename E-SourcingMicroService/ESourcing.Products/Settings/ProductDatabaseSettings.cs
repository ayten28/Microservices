
namespace ESourcing.Products.Settings
{
    public class ProductDatabaseSettings : IProductDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
