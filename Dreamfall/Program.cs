using System;
using System.Diagnostics;
using WaveEngine.Adapter;

namespace Dreamfall
{
	static class Program
	{
		[STAThread]
		static void Main ()
		{
			using (App game = new App()) {
				game.Run ();
			}
		}
	}
}


