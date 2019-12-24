using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// My first documentation 
/// </summary>
/// <param name="args">Value<param>
/// <returns>Nothing</returns>
namespace Task01_Net_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            var InputFirstNumber = Console.ReadLine();

            double ParseNumber1ToDouble;
            bool Result1Number = double.TryParse(InputFirstNumber, out ParseNumber1ToDouble);

            Console.WriteLine("Second first number");
            var InputSecondNumber = Console.ReadLine();

            double ParseNumber2ToDouble;
            bool Result2Number = double.TryParse(InputSecondNumber, out ParseNumber2ToDouble);

            if (Result1Number && Result2Number)
            {
                Console.WriteLine($"X: {ParseNumber1ToDouble} Y: {ParseNumber2ToDouble}");
            }
            else
            {
                Console.WriteLine("Please write numbers!");
            }
            Console.ReadKey();

        }
    }
}
