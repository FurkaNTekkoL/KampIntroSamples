using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.Category = "Food";
            product1.ProductName = "Watermelon";
            product1.UnitPrice = 10;

            Product product2 = new Product();
            product2.Id = 56;
            product2.Category = "Food";
            product2.ProductName = "Biscuit";
            product2.UnitPrice = 4;

            Product product3 = new Product();
            product3.Id = 87;
            product3.Category = "Drink";
            product3.ProductName = "Cola";
            product3.UnitPrice = 8;

            Product product4 = new Product();
            product4.Id = 94;
            product4.Category = "Drink";
            product4.ProductName = "Sprite";
            product4.UnitPrice = 6;

            Product product5 = new Product();
            product5.Id = 102;
            product5.Category = "Drink";
            product5.ProductName = "AppleJuice";
            product5.UnitPrice = 11;

            Product[] product = new Product[] { product1, product2, product3, product4, product5 };

            for (int i = 0; i < product.Length ; i++)
            {
                Console.WriteLine(product[i].Id +" "+ product[i].Category + " " + product[i].ProductName + " " + product[i].UnitPrice);
                Console.WriteLine("*********");
            }

            foreach (var item in product)
            {
                Console.WriteLine(item.Id + " " + item.Category + " " + item.ProductName + " " + item.UnitPrice);
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
    }
}
