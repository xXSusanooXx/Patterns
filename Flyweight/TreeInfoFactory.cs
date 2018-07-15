using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Flyweight
{
	class TreeInfoFactory
	{
		private static List<TreeInformation> treeDatas { get; set; } = new List<TreeInformation>();


		public int TreeInfoCount
		{
			get { return treeDatas.Count; }
		}

		public void ShowAllTrees()
		{
			foreach (var t in treeDatas.OrderBy(x => x.Mainland).ThenBy(x => x.TreeType).ThenBy(x => x.Color))
			{
				Console.WriteLine(t.Color + " " + t.TreeType + " " + t.Mainland);
			}
		}

		public TreeInformation GetOrAddTreeInfo(TreeColor color, TreeType treeType, Mainland mainland)
		{
			var treeData = treeDatas.FirstOrDefault(t => t.Color == color && t.TreeType == treeType && t.Mainland == mainland);

			if (treeData != null)
			{
				return treeData;
			}

			var newTreeData = new TreeInformation()
			{
				Color = color,
				TreeType = treeType,
				Mainland = mainland
			};

			treeDatas.Add(newTreeData);
			return newTreeData;
		}
	}
}
