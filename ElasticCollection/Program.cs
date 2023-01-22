using System.Dynamic;

dynamic expando = new ExpandoObject();
expando.Name = "John Doe";
expando.Age = 30;

Console.WriteLine("Enter a property name:");
string propertyName = Console.ReadLine();

if (expando is IDictionary<string, object> dictionary)
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