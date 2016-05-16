using System;

namespace testingControllers
{
	public class doSomethingClass
	{

		IController x,y ;

		public doSomethingClass (IController x, IController y)
		{
			this.x = x;
			this.y = y;
		}
		public void update()
		{
			if (x.Mode == 'e' || y.Mode == 'e')			
				Console.WriteLine ("MODE = 0, that is x.mode or y.mode = {0}",'e');
			else 
				Console.WriteLine ("MODE = 1, that is neither x.mode nor y.mode = {0}",'e');						
		}
	}
}

