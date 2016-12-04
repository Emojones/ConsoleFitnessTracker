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
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            { 
                // Prompt user for minutes exercised 
                Console.Write("Enter how many minutes you exercised or type quit to exit: ");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    keepGoing = false;
                }
                else
                {
                    int minutes = int.Parse(input);

                    // Add minutes exercised to total 
                    runningTotal = runningTotal + minutes;

                    // Display total minutes exercised to the screen 
                    Console.WriteLine("You've exercised for " + runningTotal + " minutes.");

                    // Repeat until user quits
                }
                
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
