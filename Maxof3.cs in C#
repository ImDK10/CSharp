using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMaxof3
{
    class Program
    {
        static void MaxOf3(int x , int y, int z)
        {
            if(x  > y && x > z)
            {
                Console.WriteLine("{0} is Greatest among {0} {1} {2}", x,y,z);
            }
            else if(y > x && y > z)
            {
                Console.WriteLine("{0} is Greatest among {0} {1} {2}", y, x, z);
            }
            else
            {
                Console.WriteLine("{0} is Greatest among {0} {1} {2}", z, y,x);
            }
            
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            string a, b, c;
            Console.Write("Enter Num1: ");
            a = Console.ReadLine();
            Console.Write("Enter Num2: ");
            b = Console.ReadLine();
            Console.Write("Enter Num3: ");
            c = Console.ReadLine();


            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int num3 = Convert.ToInt32(c);

            MaxOf3(num1, num2, num3);

        }
    }
}
