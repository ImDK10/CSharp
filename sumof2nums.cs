using System;

namespace HelloWorld 
{
            	class Program 
             	{
		public static void Main(string[] args )
		{
			string a , b;

			Console.WriteLine("Enter a Numer: ");
			a = Console.ReadLine();
			Console.WriteLine("Enter a Numer: ");
			b = Console.ReadLine();

			int x = Convert.ToInt32(a);
			int y = Convert.ToInt32(b);

			int z = x+y;
			Console.WriteLine("Sum :" + z);
		}
	}

}

