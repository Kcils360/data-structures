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
            //lnklist.FindMiddle();

            Console.WriteLine("Please type a number to find n from end");
            lnklist.NthFromEnd(Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();


            Console.WriteLine("Please type the value of the node to be removed");
            lnklist.DeleteNode(Console.ReadLine());

            Console.WriteLine("Please enter a new name for the list");
            var newNode = Console.ReadLine();
            Console.WriteLine("Enter the name to insert AFTER");
            var whereNode = Console.ReadLine();
            lnklist.DubLinkLists(newNode, whereNode);


            Console.Read();


        }
    }
}