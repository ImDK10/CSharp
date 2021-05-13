using System;

namespace HelloWorld 
{
            	class Program 
             	{
		public static void Main(string[] args)
		{

			string c , d;

			Console.Write("Enter C: ");
			c = Console.ReadLine();
			Console.Write("Enter D: ");
			d = Console.ReadLine();

			int x = Convert.ToInt32(c);
			int y = Convert.ToInt32(d);

			x = x+y; //(5+10)
			y = x-y;  //(15-10)
			x = x-y;  //(15-5)

			Console.WriteLine("New C:"+x); 
			Console.WriteLine("New D: "+y);
		}
	}

}

