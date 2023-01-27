using System.Dynamic;

namespace Elastic
{
    public class ProductItem
    {

        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Hp", Quantity = 30, Price = 2300.5, Category = "Laptops", OrderCount = 100 },
            new Product { Id = 2, Name = "Samsung", Quantity = 40, Price = 840, Category = "Phones", OrderCount = 400 },
            new Product { Id = 3, Name = "Konica", Quantity = 10, Price = 290.65, Category = "Printers", OrderCount = 300 }

        };
       public static void ListAll(List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id} {product.Name} {product.Quantity} {product.Price} {product.Category} {product.OrderCount}");
            }
        }          

    public static void ListProducts(string[] propertyNames)
        {
            Console.WriteLine("\n  List of Products based on propertyNames entered\n  ============================================\n");

            foreach (Product product in products)
            {
                dynamic productProperty = new ExpandoObject();

                productProperty.Id = product.Id;
                productProperty.Name = product.Name;

                productProperty.Quantity = product.Quantity;
                productProperty.Price = product.Price;

                productProperty.Category = product.Category;
                productProperty.OrderCount = product.OrderCount;


                foreach (string property in propertyNames)
                {
                    switch (property)
                    {
                        case "" and "" and "" and "" and "" and "":
                            Console.Write($"  {productProperty.Id}, {productProperty.Name}, {productProperty.Quantity}, ${productProperty.Price}, {productProperty.Category}, {productProperty.OrderCount}");
                            break;

                        case "id":
                            Console.Write($"  {productProperty.Id},");
                            break;

                        case "name":
                            Console.Write($"  {productProperty.Name},");
                            break;

                        case "quantity":
                            Console.Write($"  {productProperty.Quantity},");
                            break;

                        case "price":
                            Console.Write($"  ${productProperty.Price},");
                            break;

                        case "category":
                            Console.Write($"  {productProperty.Category},");
                            break;

                        case "ordercount":
                            Console.Write($"  {productProperty.OrderCount},");
                            break;

                        default:
                            throw new InvalidOperationException();
                    }
                }

                Console.WriteLine("\n");
            }
        }
    }

}
