using System.Dynamic;

namespace Elastic
{
    public class ProductItem
    {

        public static void run()
        {
            List<ExpandoObject> list = new List<ExpandoObject>();

            dynamic obj1 = new ExpandoObject();
            obj1.Id = 30;
            obj1.Name = "John Doe";
            obj1.Quantity = 30;
            obj1.Price = 1500;
            obj1.Category = "Laptops";
            obj1.OrderCount = 1000;

            dynamic obj2 = new ExpandoObject();
            obj2.Id = 25;
            obj2.Name = "Samsung";
            obj2.Quantity = 400;
            obj2.Price = 200;
            obj2.Category = "Phones";
            obj2.OrderCount = 4000;

            dynamic obj3 = new ExpandoObject();
            obj3.Id = 3;
            obj3.Name = "Konica";
            obj3.Quantity = 500;
            obj3.Price = 250;
            obj3.Category = "Printers";
            obj3.OrderCount = 3000;

            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);


            dynamic enumerator = list.GetEnumerator();

            try
            {
                Console.WriteLine("List of all Properties in the Product");
                while (enumerator.MoveNext())
                {
                    dynamic item = (ExpandoObject)enumerator.Current;

                    Console.WriteLine($"\n{item.Id}, {item.Name}, {item.Quantity}, {item.Price}, {item.Category}, {item.OrderCount}");

                }
            }
            finally
            {
                enumerator.Dispose();
            }

        Start:
            Console.WriteLine("\n\nEnter any of these properties to view <Name, Id, Quantity, Category, Price,OrderCount>:\n");
            string propertyName = Console.ReadLine();


            foreach (var obj in list)
            {
                if (obj is IDictionary<string, object> dictionary)
                {
                    if (dictionary.ContainsKey(propertyName))
                    {
                        Console.WriteLine(dictionary[propertyName]);
                    }
                    else
                    {
                        Console.WriteLine($"Property '{propertyName}' does not exist.");
                    }
                }
            }
            Console.WriteLine("\npress enter to view more properties or 'q' to quit");

            string input = Console.ReadLine().ToLower();
            if (input == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                goto Start;
            }


        }
    }

}
