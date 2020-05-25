/*
 *  C# Program to Find all the numbers from range R divisible by each int array N
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace DivisibleByCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var divisibleByNumbers = new int[] {4, 7}; // Add into this array the divisible numbers By to be verified
            int initialNumberRange = 1;
            int finalNumberRange = 100; // Final number is included into calculation.
            var resultDetailedSB = new StringBuilder();
            var resultUniqueSimplifiedSB = new StringBuilder();
            var resultMatchAllDivisibleCasesSB = new StringBuilder();

            for (int i = initialNumberRange; i <= finalNumberRange; i++)
            {
                var isADivisibleNumber = false;
                foreach (var divisibleByNumber in divisibleByNumbers)
                {
                    if (i % divisibleByNumber == 0)
                    {
                        resultDetailedSB.AppendFormat("{0}({1}),", i, divisibleByNumber);
                        isADivisibleNumber = true;
                    }
                }
                if (isADivisibleNumber)
                {
                    resultUniqueSimplifiedSB.AppendFormat("{0},", i);
                }
            }

            Console.WriteLine("The range of numbers divisibles are: (In parentheses the divisible for that number)");
            Console.WriteLine(resultDetailedSB.ToString());
            Console.WriteLine();
            Console.WriteLine("Divisible numbers not repeated: ");
            Console.WriteLine(resultUniqueSimplifiedSB);
            Console.WriteLine();
            Console.WriteLine("Divisible numbers not repeated and not separated by comma: ");
            Console.WriteLine(resultUniqueSimplifiedSB.Replace(",", ""));
            Console.ReadLine();
        }
    }
}
