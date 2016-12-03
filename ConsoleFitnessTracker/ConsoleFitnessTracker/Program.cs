using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFitnessTracker
{
    class Program
    {
        static void Main()
        {
            // Prompt user for minutes exercised 
            Console.Write("Enter how many minutes you exercised: ");

            string input = Console.ReadLine();

            // Add minutes exercised to total 
            // Display total minutes exercised to the screen 
            Console.WriteLine("You've exercised for " + input + " minutes.");
            // Repeat until user quits    
        }
    }
}
