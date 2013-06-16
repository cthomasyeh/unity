using System;

namespace UnsafeCodeApplication

{

	class Program

	{

		static unsafe void Main(string[] args)

		{

			int var = 20;

			int var2 = 30;

			int* p = &var;

			Console.WriteLine("Data is: {1} {0}", var, var2);

			Console.WriteLine("Address is: {0}",  (int)p);

			Console.ReadKey();

		}

	}

}