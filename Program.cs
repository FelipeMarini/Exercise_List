using System;
using System.Collections.Generic;
using Exercise_Lists.Classes;

namespace Object_List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Product p1 = new Product(50,"Potato",4f);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Attributes defined when creating object with constructor method:");
            Console.WriteLine();
            Console.WriteLine(p1.Code);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Changing p1 attributes thanks to get/set defined in Product class for Code, Name and Price:");
            Console.WriteLine(p1.Code = 10);
            Console.WriteLine(p1.Name = "Carrot");
            Console.WriteLine(p1.Price = 12f);

Console.WriteLine("After changing p1 attributes with get/set, defined in the Product class for Code, Name and Price:");

            Console.WriteLine();
            Console.WriteLine(p1.Code);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Price);


            List<Product> products = new List<Product>();

            
            products.Add(new Product(1,"Apple Watch",3522.50f));
            products.Add(new Product(8,"Xiaomi Watch",1536.90f));
            products.Add(new Product(78,"Zenfone Asus",2400.70f));
            products.Add(new Product(9,"Samsung A10",1785.60f));
            products.Add(new Product(11,"Motorola G8",1200f));


            
            
            Console.WriteLine();
            Console.WriteLine("Showing list of products with p2 added manually::");


            Product p2 = new Product();
            p2.Code = 68;
            p2.Name = "Iphone 12";
            p2.Price = 8952.56f;

            products.Add(p2);


            foreach (Product element in products)
            {
                Console.WriteLine();
                Console.WriteLine(element.Name);
            }

            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Removing item 3 from index with RemoveAt() (Samsung):");
            
            products.RemoveAt(3);


            foreach (Product element in products)
            {
                Console.WriteLine();
                Console.WriteLine(element.Name);
            }

            
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Removing Zenfone with RemoveAll(lambda) from its code#78:");
            
            products.RemoveAll(x => x.Code == 78);


             foreach (Product element in products)
            {
                Console.WriteLine();
                Console.WriteLine(element.Name);
            }



        }
    }
}
