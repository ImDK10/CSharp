using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPali
{
    class Program
    {
        static void ReverseString(string s)
        {
            for (int i = s.Length; i >= 1; i--)
            {
                char x = s[i - 1];
                string s1 = Convert.ToString(x);
                Console.Write(s1);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {

            string s;
            Console.WriteLine("Enter a String: ");
            s = Console.ReadLine();

            ReverseString(s);
        }
    }
}
