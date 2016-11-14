using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 15 == 0)
				{
					Console.WriteLine("FizzBuzz");
					continue;
				}
				if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
					continue;
				}
				if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
					continue;
				}
				Console.WriteLine(i);
			}
		}
	}
}
