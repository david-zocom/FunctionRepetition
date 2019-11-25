using System;

namespace FunctionRepetition
{
	class Program
	{
		static void Main(string[] args)
		{
			// Write a function ArrayDiff that calculates the difference between the largest and smallest values of an array
			// Example: [3, 3, -100, 1, 2, 3, 5, 4]
			// Difference between 5 and 1 is 5-1==4

			// create array - to test our code
			// variables
			// calculate min and max
			// for loop - do something for every element of the array
			// maybe use an if statement?
			// calculate difference
			// print the result to the console - only when testing
			// (when done: remove the test array and the printing)
			int[] array1 = new int[] { 5, 2, 3, 8, 4, -1, 6, 4 };
			ArrayDiff(array1);
		}

		static int ArrayDiff(int[] array)
		{
			int maxSoFar = array[0];
			int minSoFar = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				if(array[i] > maxSoFar) { maxSoFar = array[i]; }
				if(array[i] < minSoFar) { minSoFar = array[i]; }
			}
			Console.WriteLine("Max: " + maxSoFar);
			Console.WriteLine("Min: " + minSoFar);
			return 0;
		}
	}
}
