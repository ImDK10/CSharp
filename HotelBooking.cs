using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHotelBooking
{
    public class Hotel
    {
        public string name;
        public long aadhar;
        public int numofdays;
        public string AC_NONAC;
        public DateTime Check_in_Date;
        public long mobile;
        public int persons;
        public string single_double;
        public string hot_coldwater;


        public void hotelmethod()
        {
            Console.WriteLine("Welcome to VM Hotel");
            Console.WriteLine("********************************");
            Console.WriteLine("CHOOSE YOUR BOOKING OPTION:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"1.Single\n2.Deluxe\n3.suite\n4.Exit");
            Console.WriteLine("********************************");
        }
    }
    class Single : Hotel
    {
        public void SingleType()
        {

            Console.WriteLine("1.SINGLE ROOM");
            Console.WriteLine("********************************");
            Console.Write("Enter your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your aadhar number: ");
            aadhar = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your Number of days: ");
            numofdays = Convert.ToInt32(Console.ReadLine());
            Console.Write("AC / NON-AC: ");
            AC_NONAC = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Check in date: ");
            Check_in_Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            mobile = Convert.ToInt64(Console.ReadLine());

        }

        public void SingleDisplay()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Aadhar: " + aadhar);
            Console.WriteLine("numofdays: " + numofdays);
            Console.WriteLine("Ac/non_ac: " + AC_NONAC);
            Console.WriteLine("Check_in: " + Check_in_Date.ToString("MM/dd/yyyy"));
            DateTime checkout = Check_in_Date.AddDays(numofdays);
            Console.WriteLine("Check_out: " + checkout.ToString("MM/dd/yyyy"));
            Console.WriteLine("Mobile: " + mobile);
            Console.WriteLine("********************************");
 
        }


    }

    class Deluxe : Hotel
    {
        public void DeluxeTpye()
        {
            Console.WriteLine("2.DELUXE ROOM");
            Console.WriteLine("********************************");
            Console.Write("Enter your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your aadhar number: ");
            aadhar = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your aadhar number: ");
            aadhar = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your Number of days: ");
            numofdays = Convert.ToInt32(Console.ReadLine());
            Console.Write("AC / NON-AC: ");
            AC_NONAC = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Check in date: ");
            Check_in_Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            mobile = Convert.ToInt64(Console.ReadLine());
        }

        public void DeluxeDisplay()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Aadhar: " + aadhar);
            Console.WriteLine("numofdays: " + numofdays);
            Console.WriteLine("Ac/non_ac: " + AC_NONAC);
            Console.WriteLine("Check_in: " + Check_in_Date.ToString("MM/dd/yyyy"));
            DateTime checkout = Check_in_Date.AddDays(numofdays);
            Console.WriteLine("Check_out: " + checkout.ToString("MM/dd/yyyy"));
            Console.WriteLine("Mobile: " + mobile);
            Console.WriteLine("********************************");
        }

    }

    class Suite : Hotel
    {
        public void SuiteType()
        {
            Console.WriteLine("3.SUITE ROOM");
            Console.WriteLine("********************************");
            Console.WriteLine("Single / Double Bedroom ? ");
            single_double = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your aadhar number: ");
            aadhar = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter your Number of days: ");
            numofdays = Convert.ToInt32(Console.ReadLine());
            Console.Write("AC / NON-AC: ");
            AC_NONAC = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Check in date: ");
            Check_in_Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Hot Water needed?");
            hot_coldwater = Convert.ToString(Console.ReadLine());

        }

        public void SuiteDisplay()
        {
            Console.WriteLine("Room Type: " + single_double);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Aadhar: " + aadhar);
            Console.WriteLine("numofdays: " + numofdays);
            Console.WriteLine("Ac/non_ac: " + AC_NONAC);
            Console.WriteLine("Check_in: " + Check_in_Date.ToString("MM/dd/yyyy"));
            DateTime checkout = Check_in_Date.AddDays(numofdays);
            Console.WriteLine("Check_out: " + checkout.ToString("MM/dd/yyyy"));
            Console.WriteLine("Mobile: " + mobile);
            Console.WriteLine("Hot Water: " + hot_coldwater);
            Console.WriteLine("********************************");
        }

    }
    class exit
    {
        public void ExitType()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Thank you for booking.");
            Console.WriteLine("********************************");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotelobject = new Hotel();
            hotelobject.hotelmethod();

            int x;

            do
            {

                 x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        {
                            Single singleobject = new Single();
                            singleobject.SingleType();
                            singleobject.SingleDisplay();
                            break;
                        }
                    case 2:
                        {
                            Deluxe deluxeobject = new Deluxe();
                            deluxeobject.DeluxeTpye();
                            deluxeobject.DeluxeDisplay();
                            break;
                        }
                    case 3:
                        {
                            Suite suiteobject = new Suite();
                            suiteobject.SuiteType();
                            suiteobject.SuiteDisplay();
                            break;
                        }
                    case 4:
                        {
                            exit exitobject = new exit();
                            exitobject.ExitType();
                            break;
                        }
                }
                

            }
            while(x != 4) ;
            Console.ReadLine();
                    

        }
    }
}
