using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSwitchCase
{
    class Program
    { 
        static void Main(string[] args)
        {
            string a, b, c;

            Console.Write("Enter NUM1:");
            a = Console.ReadLine();
            Console.Write("Enter Num2:");
            b = Console.ReadLine();
            Console.WriteLine("Enter the Operator:");
            c = Console.ReadLine();


            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);

            switch (c)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
            }

            Console.ReadLine();
        }
    }
}
