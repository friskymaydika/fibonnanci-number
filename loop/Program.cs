using System;

namespace FibonacciCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the  Fibonacci Sequence Generator!");
            Console.WriteLine("Enter the number to showhow many fibonnanci to generate (or 0 to exit):");

            while (true)
            {
                int numTerms = int.Parse(Console.ReadLine());

                if (numTerms == 0)
                {
                    Console.WriteLine("Goodbye! ");
                    break; // Exit the loop
                }

                // Initialize the first two terms
                int firstTerm = 0;
                int secondTerm = 1;

                Console.Write("Fibonacci sequence: " + firstTerm + ", " + secondTerm);

                for (int i = 2; i < numTerms; i++)
                {
                    int nextTerm = firstTerm + secondTerm;
                    Console.Write(", " + nextTerm);

                    // Update terms for the next iteration
                    firstTerm = secondTerm;
                    secondTerm = nextTerm;
                }

                Console.WriteLine("\nCalculation complete!do you want to Enter another number to sequence? (or 0 to exit):");
            }
        }
    }
}
