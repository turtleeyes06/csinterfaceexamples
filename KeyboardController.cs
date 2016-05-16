using System;
using System.IO;


namespace testingControllers
{
	public class KeyboardController : IController
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

		public KeyboardController ()
		{
		}

		public void Update()
		{
			Mode = 'c';
		}
	}
}

