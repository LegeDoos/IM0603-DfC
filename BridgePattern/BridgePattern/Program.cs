using BridgePattern.Models;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Dit is bridge pattern!");

            // create a list test
            var myList = new RobLinkedList<string>();
            int pos = myList.Size();
            myList.Insert(pos, "dit is 1");
            pos = myList.Size();
            myList.Insert(pos, "dit is 2");
            pos = myList.Size();
            myList.Insert(pos, "dit is 3");

            pos = myList.Size();
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($"{myList.ElementAtPos(i)}");
            }

            Console.WriteLine();

            myList.Remove(1);
            pos = myList.Size();
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($"{myList.ElementAtPos(i)}");
            }

        }
    }
}
