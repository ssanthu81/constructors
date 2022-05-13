using System;
namespace constructors
{
	 class Explictcons
	{
		public Explictcons()
		{
			Console.WriteLine("Constructor is called");
		}
		static void Main()
        {
			Explictcons ss = new Explictcons();
			Explictcons ss1 = new Explictcons();
			Explictcons ss2 = new Explictcons();
			Console.ReadLine();
        }
	}
}

