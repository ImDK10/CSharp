using System;

namespace HelloWorld 
{
            	class program
	{
		public static void Main(string[] args )
		{
			string a , b;

			Console.Write("Enter a Numer: ");
			a = Console.ReadLine();
			Console.Write("Enter a Numer: ");
			b = Console.ReadLine();

			int x = Convert.ToInt32(a);
			int y = Convert.ToInt32(b);

			Console.WriteLine("Addition:" +(x+y));
			Console.WriteLine("Subtraction:" +Math.Abs(x-y));
			Console.WriteLine("Multiplication:" +(x*y));
			Console.WriteLine("Division:" +(x/y));
		}
	}

}

