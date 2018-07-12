using System;
using System.Collections.Generic;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			var box = new Box()
			{
				InnerItems = new List<IShopItem>()
				{
					new Product(100),
					new Product(200),
					new Box()
					{
						InnerItems = new List<IShopItem>()
						{
							new Product(50),
							new Product(400)
						}
					}
				}
			};
			Console.WriteLine(box.Price);
		}
	}
}
