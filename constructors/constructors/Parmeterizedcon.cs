using System;
namespace constructors
{
	public class Parmeterizedcon
	{
		int x;
		public Parmeterizedcon(int i)
		{
			x = i;
			Console.WriteLine("Parameterized con" + i);
		}
		public void Display()
        {
			Console.WriteLine("value of x" + x);
        }
		static void Main()
        {
			Parmeterizedcon c1 = new Parmeterizedcon(1);
			Parmeterizedcon c2 = new Parmeterizedcon(2);

			c1.Display();
			c2.Display();
        }
	}
}

