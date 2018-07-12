using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
	class Product : IShopItem
	{
		public double Price { get; private set; }

		public Product(int price)
		{
			this.Price = price;
		}
	}
}
