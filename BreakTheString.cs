using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSeparateTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter a string:");
            s = Console.ReadLine();

            for(int i = 0; i< s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    Console.WriteLine();
                    continue;
                }
                Console.Write(s[i]);
            }
            Console.ReadLine();

            /*var parts = s.Split(' ');
            Array.ForEach(parts, Console.WriteLine);
            Console.ReadLine();*/
        }
      
    }
}
