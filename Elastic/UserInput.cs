using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elastic
{
    public class UserInput
    {
       // readonly static List<Product> products;
        public static void EnterProperty()
        {
            string[] propertyNames;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write("\n  Enter the propertyNames to display,Comma seperated! (e.g id, name): \n  ");

                    propertyNames = Console.ReadLine().ToLower().Replace(" ", "").Split(',');

                    ProductItem.ListProducts(propertyNames);

                    validInput = true;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("\n  Invalid propertyNames entered, try again!");
                }
            }
            Console.Write("\n  press 'y' to continue ;  'q' to quit \n  ");
            var response = Console.ReadLine().ToLower();

            if (response == "y")
            {
                validInput = false;
                EnterProperty();
            }
            else if (response == "q")
            {
                Environment.Exit(0);
            }
            //else { ProductItem.ListAll(products); }
        }
    }
}
