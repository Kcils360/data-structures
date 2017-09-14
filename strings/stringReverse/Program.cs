using System;
using System.Linq;

namespace lab02_gregory
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringReversal, RevWord = "";
            Console.WriteLine("Please enter a string to be reversed.");
            stringReversal = (Console.ReadLine());
 
            for ( int i = stringReversal.Length-1; i >= 0; i--)
            {
                RevWord = RevWord + stringReversal[i];
            }
            Console.WriteLine(RevWord);
            Console.Read();
        }

    }
}
//decrimented for loop

        