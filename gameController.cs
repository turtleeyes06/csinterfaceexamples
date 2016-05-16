using System;

namespace testingControllers
{
	public class gameController : IController
	{
		private char mode;
		public int Mode{ 
			get
			{
				return mode;
			}
			set
			{
				Console.WriteLine ("ENTER MODE for {0} WITH e",this.ToString());
				mode = (char)Console.Read ();
				Console.WriteLine ();
			}
		}
		public gameController ()
		{
		}
		public void Update()
		{
			Mode = 10;
		}
	}
}

