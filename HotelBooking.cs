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
        protected DateTime Checkoutdate;
        public long mobile;
        public string single_double;

        public void bookinglist()
        {
            Console.WriteLine($"{single_double}\t\t{Check_in_Date.ToString("MM/dd/yyyy")}\t\t{Checkoutdate.ToString("MM/dd/yyyy")}\t\t{name}\t\t{mobile}");
        }

        public static void bookinglistheading()
        {
            Console.WriteLine($"TYPE\t\tCHECKINN\t\tCHECKOUT\t\tNAME\t\tPHONE");
        }


        public void hotelmethod()
        {
            Console.WriteLine("Welcome to VM Hotel");
            Console.WriteLine("********************************");
            Console.WriteLine("CHOOSE YOUR BOOKING OPTION:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"1.Single\n2.Deluxe\n3.suite\n4.Exit\n5.list of bookings");
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
            Checkoutdate = Check_in_Date.AddDays(numofdays);
            mobile = Convert.ToInt64(Console.ReadLine());
            single_double = "Single";

        }

        public void SingleDisplay()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Your Booking Details");
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Aadhar: " + aadhar);
            Console.WriteLine("numofdays: " + numofdays);
            Console.WriteLine("Ac/non_ac: " + AC_NONAC);
            Console.WriteLine("Check_in: " + Check_in_Date.ToString("MM/dd/yyyy"));
            DateTime checkout = Check_in_Date.AddDays(numofdays);
            Console.WriteLine("Check_out: " + checkout.ToString("MM/dd/yyyy"));
            Console.WriteLine("Mobile: " + mobile);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************");
 
        }


    }

    class Deluxe : Hotel
    {
        public void DeluxeTpye()
        {
            Console.WriteLine("2.DELUXE ROOM");
            Console.WriteLine("********************************");
            Console.WriteLine("No.of Persons (1/2): ");
            int persons;
            persons = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= persons; i++)
            {
                Console.Write("Enter your Name{0}: ",i);
                name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter your aadhar number: ");
                aadhar = Convert.ToInt64(Console.ReadLine());
            }
            Console.Write("Enter your Number of days: ");
            numofdays = Convert.ToInt32(Console.ReadLine());
            Console.Write("AC / NON-AC: ");
            AC_NONAC = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Check in date: ");
            Check_in_Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter Mobile Number: ");
            Checkoutdate = Check_in_Date.AddDays(numofdays);
            mobile = Convert.ToInt64(Console.ReadLine());
            single_double = "Deluxe";
        }

        public void DeluxeDisplay()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Your Booking Details");
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Aadhar: " + aadhar);
            Console.WriteLine("numofdays: " + numofdays);
            Console.WriteLine("Ac/non_ac: " + AC_NONAC);
            Console.WriteLine("Check_in: " + Check_in_Date.ToString("MM/dd/yyyy"));
            DateTime checkout = Check_in_Date.AddDays(numofdays);
            Console.WriteLine("Check_out: " + checkout.ToString("MM/dd/yyyy"));
            Console.WriteLine("Mobile: " + mobile);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************");
        }

    }

    class Suite : Hotel
    {
        string hot_coldwater;
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
            Checkoutdate = Check_in_Date.AddDays(numofdays);
            mobile = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Hot Water needed?");
            hot_coldwater = Convert.ToString(Console.ReadLine());
            single_double = "Suite";

        }

        public void SuiteDisplay()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Your Booking Details");
            Console.WriteLine("********************************");
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************************");
        }

    }
    class Listbookings : Hotel
    {
    }
    class Exit
    {
        public void ExitType()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("Thank you for booking.");
            Console.WriteLine("********************************");
        }
    }
    static class Program
    {
        static void Main(string[] args)
        {
            Hotel hotelobject = new Hotel();
            hotelobject.hotelmethod();


            int x;
            int bookingcount = 0;

            Hotel[] hotelbookinglist = new Hotel[100];


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
                            hotelbookinglist[bookingcount] = singleobject;
                            bookingcount++;
                            break;
                        }
                    case 2:
                        {
                            Deluxe deluxeobject = new Deluxe();
                            deluxeobject.DeluxeTpye();
                            deluxeobject.DeluxeDisplay();
                            hotelbookinglist[bookingcount] = deluxeobject;
                            bookingcount++;
                            break;
                        }
                    case 3:
                        {
                            Suite suiteobject = new Suite();
                            suiteobject.SuiteType();
                            suiteobject.SuiteDisplay();
                            hotelbookinglist[bookingcount] = suiteobject;
                            bookingcount++;
                            break;
                        }
                    case 4:
                        {
                            Exit exitobject = new Exit();
                            exitobject.ExitType();
                            break;
                        }
                    case 5:
                        {
                            Hotel.bookinglistheading();
                            for(int i = 0; i<bookingcount;i++)
                            {
                                hotelbookinglist[i].bookinglist();
                            }
                            break;
                        }
                }
                

            }
            while(x != 4) ;
            Console.ReadLine();
                    

        }
    }
}
