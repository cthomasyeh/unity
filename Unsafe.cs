using System;

namespace test
{
	class MainClass
	{
		public unsafe static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int i = 75;
			float f = 53.005f;
			double d = 2345.7652;
			bool b = true;
			unsafe {
				int* intPtr;

				Console.WriteLine(i.ToString());
				Console.WriteLine(f.ToString());
				Console.WriteLine(d);
				Console.WriteLine(b.ToString ());
				intPtr = &i;
				Console.WriteLine (*intPtr);
			}
			Console.ReadKey();
			//System.Threading.Thread.Sleep (5000);
		}
	}
}
