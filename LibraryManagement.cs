using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLibraryManagement
{
    class Program
    {
        static void Library(char options)
        {
            switch (options)
            {
                case (char)1:
                    Console.WriteLine("Welcome to Compuetr Books Section");
                    Console.WriteLine("CS_BOOK1");
                    Console.WriteLine("CS_BOOK2");
                    Console.WriteLine("CS_BOOK3");
                    Console.WriteLine("CS_BOOK4");
                    break;
                case (char)2:
                    Console.WriteLine("Welcome to Mathematics Books Section");
                    Console.WriteLine("Math_BOOK1");
                    Console.WriteLine("Math_BOOK2");
                    Console.WriteLine("Math_BOOK3");
                    Console.WriteLine("Math_BOOK4");
                    break;
                case (char)3:
                    Console.WriteLine("Welcome to History Books Section");
                    Console.WriteLine("History_BOOK1");
                    Console.WriteLine("History_BOOK2");
                    Console.WriteLine("History_BOOK3");
                    Console.WriteLine("History_BOOK4");
                    break;
                case (char)4:
                    Console.WriteLine("Welcome to English Books Section");
                    Console.WriteLine("Eng_BOOK1");
                    Console.WriteLine("Eng_BOOK2");
                    Console.WriteLine("Eng_BOOK3");
                    Console.WriteLine("Eng_BOOK4");
                    break;

            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string option;
            Console.WriteLine("Welcome to Central Library");
            Console.WriteLine("Available Book Sections");
            Console.WriteLine("1 - Computers \n" + "2 - Mathematics \n" + "3 - History \n" + "4 - English \n");
            Console.Write("Enter the required section: ");
            option = Console.ReadLine();
            int d = Convert.ToInt32(option);

            Library((char)d);
        }
    }
}
