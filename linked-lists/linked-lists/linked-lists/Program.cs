using System;

namespace linkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();

            lnklist.AddAtLast(1);
            lnklist.AddAtLast(2);
            lnklist.AddAtLast(3);
            lnklist.AddAtLast(4);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            Console.ReadKey();
        }
    }

}
