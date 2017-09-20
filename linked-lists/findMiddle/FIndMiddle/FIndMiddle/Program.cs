using System;

namespace FIndMiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lnklist = new LinkedList();

            lnklist.AddAtLast("Gregory");
            lnklist.AddAtLast("Adam");
            lnklist.AddAtLast("Cam");
            lnklist.AddAtLast("CodeFellows");
            lnklist.PrintAllNodes();
            Console.WriteLine();
            lnklist.FindMiddle();

            Console.ReadKey();
        }
    }
}
