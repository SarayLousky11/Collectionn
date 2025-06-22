using System;
using System.Collections.Generic;
namespace Collection
{
    class Program
    {
        static void Main()
        {
            ICollectionOperations operations = new CollectionManager();

            List<string> list = new List<string> { "guy", "guy", "daniel", "ben" };
            Console.WriteLine("Before:");
            PrintList(list);
            operations.ListOperations(list);
            Console.WriteLine("After :");
            PrintList(list);

            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "scuba", 6 },
            { "math", 3 }
        };
            Console.WriteLine("exe 2");
            Console.WriteLine("Before");
            PrintDictionary(dict);
            operations.DictionaryOperations(dict);
            Console.WriteLine("After:");
            PrintDictionary(dict);

            Stack<DateTime> stack = new Stack<DateTime>();
            stack.Push(new DateTime(2023, 1, 1));
            Console.WriteLine("exe 3");
            Console.WriteLine("Before");
            Console.WriteLine(stack.Peek());
            operations.StackOperations(stack);
            Console.WriteLine("After :");
            Console.WriteLine(stack.Peek());
        }

        static void PrintList(List<string> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}