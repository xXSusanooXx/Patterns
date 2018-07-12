using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Composite
{
	class Box : IShopItem
	{
		public double Price
		{
			get
			{
				return InnerItems.Sum(x => x.Price);
			}
		}

		public List<IShopItem> InnerItems { get; set; } = new List<IShopItem>();
	}
}
