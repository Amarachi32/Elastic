using System.Dynamic;

namespace Elastic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> products = new List<Product>();

            var item1 = new Product
            {
                Id = 1,
                Name = "Dell",
                Quantity = 1,
                Price = 300,
                Category = "laptop",
            };
            var item2 = new Product
            {
                Id = 2,
                Name = "Hp",
                Quantity = 3,
                Price = 400,
                Category = "Desktop",
            };
            var item3 = new Product
            {
                Id = 3,
                Name = "Lenovo",
                Quantity = 6,
                Price = 1000,
                Category = "Phone",
            };
            products.Add(item1);
            products.Add(item2);
            products.Add(item3);

            Console.WriteLine("enter any of these property to view their values [Id, Name, Quantity, Price, Category]");
            string name = Console.ReadLine();
            Console.Write($" Content: {item1.GetPropVale(name)}\t");
            Console.Write($" {item2.GetPropVale(name)}\t");
            Console.Write($" {item3.GetPropVale(name)}\n\n");





            Console.WriteLine("press enter to view all");
            Console.Read();

            foreach (var it in products)
            {
                dynamic expando;
                expando = new ExpandoObject();
                expando.getAll = $"{it.Id},{it.Name}, {it.Price.ToString()}, {it.Category}";
                Console.WriteLine(expando.getAll);
            }
            Console.ReadKey();
        }
    }
}