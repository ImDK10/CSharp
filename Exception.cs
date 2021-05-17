using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptions
{
    class Program
    {
        static void CalculateDivision()
        {
            int numerator = 0, denominator = 0;
            int? result = null;

            try
            {

                Console.Write("Enter Numerator: ");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter denominator: ");
                denominator = Convert.ToInt32(Console.ReadLine());

                result = numerator / denominator;

                Console.WriteLine($"{numerator} / {denominator} = {result}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        static void Main(string[] args)
        {
            CalculateDivision();
            Console.ReadLine();
        }
    }
}
