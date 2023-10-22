using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class DataAdding
    {
        public static void AddProduct()
        {
            Product product1 = new Product(1,"Iphone", "The best than Iphone 11","Apple","Iphone 11",1200);
            Product product2 = new Product(2,"Galaxy", "The best than Galaxy S2","Samsung","Galaxy S7",90000);
            Product product3 = new Product(3);
            Data.products.Add(product1);
            Data.products.Add(product2);

        }

    }
}
