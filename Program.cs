using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTaxCal
{
    class Program
    {
        static void TaxCalculation(int salary)
        {
            if(salary < 10000 )
            {
                Console.WriteLine("Your Tax Percentage is 5%");
                Console.WriteLine("Total Tax:" + ((salary * 5) / 100));
            }
            else if(salary >= 10000 && salary <= 100000)
            {
                Console.WriteLine("Your Tax Percentage is 8%");
                Console.WriteLine("Total Tax:" + ((salary * 8) / 100));
            }
            else
            {
                Console.WriteLine("Your Tax Percentage is 8.5%");
                Console.WriteLine("Total Tax :" + ((salary * 8.5) / 100));
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your Salary: ");
            int Salary = Convert.ToInt32(Console.ReadLine());
            TaxCalculation(Salary);

        }
    }
}
