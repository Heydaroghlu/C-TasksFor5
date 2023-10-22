using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(int yeniId)
        {
            Id = yeniId;
        }
        public Product(int newId,string newName,string newDesc,string newBName,string newModel,long stock)
        {
            Id = newId;
            Name = newName;
            Description = newDesc;
            BrandName= newBName;
            ModelName= newModel;
            StockCount = stock;
        }
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public long StockCount { get; set; }
        public static void Reclam(List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"product in melumatlari- Id:{product.Id} Name: {product.Name} Description: {product.Description} BrandName: {product.BrandName} StockCount: {product.StockCount}");
            }
        }
    }
}
