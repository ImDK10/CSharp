using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter the num:");
            x = Console.ReadLine();

            int num = Convert.ToInt32(x);

            switch (num)
            {
                case 1:
                    Console.WriteLine("{0}st day of the week is Monday",num);
                    break;
                case 2:
                    Console.WriteLine("{0}nd day of the week is Tuesday",num);
                    break;
                case 3:
                    Console.WriteLine("{0}rd day of the week is Wednesday",num);
                    break;
                case 4:
                    Console.WriteLine("{0}th day of the week is Thursday",num);
                    break;
                case 5:
                    Console.WriteLine("{0}th day of the week is Friday",num);
                    break;
                case 6:
                    Console.WriteLine("{0}th day of the week is Saturday",num);
                    break;
                case 7:
                    Console.WriteLine("{0}th day of the week is Sunday",num);
                    break;
            }
            Console.ReadLine();
        }
    }
}
