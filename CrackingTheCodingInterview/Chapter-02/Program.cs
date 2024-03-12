using System.Collections.Generic;
using System.Threading.Channels;

public partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Solutions for chapter 2: Linked Lists");

        #region 2.1 Remove Dups
        try
        {
            Random rnd = new Random();

            LinkedList<int> originalList = new LinkedList<int>();

            LinkedListNode<int> first = new(rnd.Next(0, 15));
            originalList.AddFirst(first);

            LinkedListNode<int> second;
            for (int count = 1; count < 8; count++)
            {
                second = new LinkedListNode<int>(rnd.Next(0, 15));

                originalList.AddAfter(first, second);

                first = second;
            }

            LinkedList<int> newlList = RemoveDupsA(originalList);

            if (newlList == null)
            {
                Console.WriteLine("The Orinal List is null or empty");
                return;
            }

            // Show orinalList
            Console.WriteLine($"Orinal List: \t{string.Join("\t", originalList.Select(item => item.ToString()))}");

            // Show newlList
            Console.Write($"New List:\t");
            newlList.ToList().ForEach(item => Console.Write($"{item}\t"));
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong with question 2.1. Error: {ex}");
        }
        #endregion
    }
}