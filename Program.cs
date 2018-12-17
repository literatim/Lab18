using System;

namespace Lab18
{
	class Program
	{
		const int size = 11;

		static void Main(string[] args)
		{

			int[] arrayOne = { 2, 4, 4, 90, 41, 64, 100, 1, 1, 16, 17 };

			Console.Write($"Array = {arrayOne}");

			RunCounterAlgorithm(arrayOne);

			Console.ReadKey();
		}

		// James -- Everything in your linked list class was looking good, then I saw this... not sure what you are going  for here because
		// this is an empty method my dude.
		static void RunCounterAlgorithm(int[] arrayOne)
		{

		}
	}
}