using System.Dynamic;
namespace Elastic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Elastic Collection using Expando Object****************\n\n");

            ProductItem.run();
            Console.ReadKey();
        }
    }
}