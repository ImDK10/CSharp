using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMajorMinor
{
    class Program
    {
        static void MajorMinor(int x)
        {
            if(x<=19)
            {
                Console.WriteLine("Minor");
            }
            else
            {
                Console.WriteLine("Major");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter Age Of the Person: ");
            x = Console.ReadLine();

            int Age = Convert.ToInt32(x);

            MajorMinor(Age);
        }
    }
}
