using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarkGrade
{
    class Program
    {
        static void MarkGrade(int x)
        {
            if (x >= 90)
            {
                Console.WriteLine("Grade: A+ ");
            }
            else if (x >= 80 && x <= 89)
            {
                Console.WriteLine("Grade: A ");
            }
            else if (x >= 70 && x <= 79)
            {
                Console.WriteLine("Grade: B+ ");
            }
            else if (x >= 60 && x <= 69)
            {
                Console.WriteLine("Grade: B ");
            }
            else if (x >= 50 && x <= 59)
            {
                Console.WriteLine("Grade: C ");
            }
            else if (x >= 45 && x <= 49)
            {
                Console.WriteLine("Grade: D ");
            }
            else
            {
                Console.WriteLine("Grade: F ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            String x;
            Console.WriteLine("Enter your Marks: ");
            x = Console.ReadLine();

            int Marks = Convert.ToInt32(x);

            MarkGrade(Marks);

        }
    }
}
