using ESourcing.Products.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESourcing.Products.Data
{
    public class ProductContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection) 
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct) 
            {
                productCollection.InsertManyAsync(GetConfigureProducts());
            }
        }

        private static IEnumerable<Product> GetConfigureProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                Name="Iphone X",
                Summary ="Iphone X Summary",
                Description = "test 1",
                ImageFile = "aaa.png",
                Price = 950.00M,
                Category = "Smart Phone"

                },
                new Product()
                {
                Name="Iphone 12",
                Summary ="Iphone 10 Summary",
                Description = "test 2",
                ImageFile = "aaa1.png",
                Price = 1950.00M,
                Category = "Smart Phone"

                },
                new Product()
                {
                Name="Iphone 11",
                Summary ="Iphone 11 Summary",
                Description = "test 1",
                ImageFile = "aaa2.png",
                Price = 1000.00M,
                Category = "Smart Phone"

                }
            };
        }
    }
}
