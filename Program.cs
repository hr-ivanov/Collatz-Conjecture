using System;
using System.Numerics;
namespace CollatzConjecture
{
	class Program
	{
		static int order = 0;
		public static void Generate(BigInteger n)
        {
			Console.WriteLine("№ {0}. - {1}",order,n);
			order++;
			if (n % 2 == 0)
			{
				Generate(n/2);
			}
			else if (n == 1)
			{
				return;
			}
			else
            {
				Generate((3 * n) + 1);
			}
        }
		public static void Main(string[] args)
		{
			Console.Write("Enter a whole number: ");
			BigInteger number = BigInteger.Parse(Console.ReadLine());
			Generate(number);

			Console.WriteLine("Hello world!");
		}
	}
}