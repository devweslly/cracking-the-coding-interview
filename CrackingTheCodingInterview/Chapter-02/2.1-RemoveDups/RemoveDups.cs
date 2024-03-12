using System;
using System.Collections.Generic;

public partial class Program
{
    /*
        * Remover duplicatas de uma lista vinculada
    */

    #region Solution 1
    public static LinkedList<int> RemoveDupsA(LinkedList<int> node)
    {
        Dictionary<int, string> set = new Dictionary<int, string>();
        LinkedList<int> previous = new LinkedList<int>();

        if (node == null)
            return null;

        foreach (int i in node)
        {
            if (!set.ContainsKey(i))
                set.Add(i, String.Empty);
        }

        int lastValueAdd = -1;
        foreach (int currentValue in set.Keys)
        {
            if (previous.Count <= 0)
            {
                previous.AddFirst(currentValue);
                lastValueAdd = currentValue;
                continue;
            }

            LinkedListNode<int>? valueBefore = previous.Find(lastValueAdd);
            previous.AddAfter(valueBefore, currentValue);

            lastValueAdd = currentValue;
        }

        return previous;
    }
    #endregion

    #region Solution 2 -  No Buffer Allowed
    public static void RemoveDupsB(LinkedList<int> head) { }
    #endregion
}