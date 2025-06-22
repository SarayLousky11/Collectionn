using System;
using System.Collections.Generic;
using System.Linq;

public class CollectionManager : ICollectionOperations
{
    public void ListOperations(List<string> list)
    {
        if (list == null || list.Count == 0) return;

        // 1. 
        int middleIndex = list.Count / 2;
        list.RemoveAt(middleIndex);

        // 2. 
        if (list.Contains("mama"))
        {
            list.Add("6");
        }

        // 3. 
        int Index = list.IndexOf("course59");
        if (Index >= 0 && Index % 2 != 0)
        {
            list.Reverse();
        }

        // 4
        var distinctValues = list.Distinct().Count();
        if (distinctValues == 3 && list.Count >= 2)
        {
            list.InsertRange(2, new List<string> { "2", "3", "4" });
        }
    }


    public void DictionaryOperations(Dictionary<string, int> dictionary)
    {
        if (dictionary == null) return;

        if (dictionary.ContainsKey("scuba") && dictionary["scuba"] == 6)
        {
            if (!dictionary.ContainsKey("dive"))
            {
                dictionary.Add("dive", 6);
            }
        }
    }

    public void StackOperations(Stack<DateTime> stack)
    {
        if (stack == null || stack.Count == 0) return;

        DateTime top = stack.Peek();
        DateTime now = DateTime.Now;

        if (top < now)
        {
            stack.Pop();
            stack.Push(now);
        }
    }

}
