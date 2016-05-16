using System;

namespace testingControllers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IController x = new KeyboardController ();
			IController y = new KeyboardController ();
			doSomethingClass z = new doSomethingClass (x,y);

			while (x.Mode != 'z' && y.Mode != 'z') 
			{

				x.Update ();
				y.Update ();
				z.update ();
			
			
			
			
			}


		}
	}
}
