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
            lnklist.AddAtLast("John");
            lnklist.AddAtLast("Lola");
            lnklist.AddAtLast("Evette");
            lnklist.AddAtLast("Tom");
            lnklist.AddAtLast("Adrienne");
            lnklist.AddAtLast("Derryl");


            lnklist.PrintAllNodes();
            Console.WriteLine();
            lnklist.FindMiddle();

            Console.WriteLine("Please type a number to find n");
            lnklist.NthFromEnd(Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}