using System;
using System.Collections.Generic;

namespace Momento
{
	class Program
	{
		static void Main(string[] args)
		{
			var momentos = new List<IMemento>();

			Complex c = new Complex() { R = 3, I = 3 };

			momentos.Add(c.GetMemento());

			c.R = 5;
			c.I = 2;

			momentos.Add(c.GetMemento());

			c.R = 4;
			c.I = 6;

			momentos.Add(c.GetMemento());

			foreach (var momento in momentos)
			{
				momento.RestoreState();
				Console.WriteLine($"R:{c.R};I:{c.I}");
			}
			Console.Read();
		}
	}
}
