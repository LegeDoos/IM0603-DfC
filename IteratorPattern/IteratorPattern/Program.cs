using IteratorPattern.Models;

namespace IteratorPattern
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World! This is my basic iterator pattern!");
            
            string[] items = ["item1", "item2", "item3"];
            MyCollection collection = new(items);

            // expliciet
            Console.WriteLine("Expliciet");
            var enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            // impliciet gebruik
            Console.WriteLine("Impliciet");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
