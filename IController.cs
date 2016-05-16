using System;

namespace testingControllers
{
	public interface IController
	{
		int Mode{ get; set;}
		void Update();
	}
}

