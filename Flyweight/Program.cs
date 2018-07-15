using System;
using System.Linq;
using System.Collections.Generic;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			var treeDataFactory = new TreeInfoFactory();
			var forest = new List<Tree>();

			Random r = new Random();
			for (var i = 0; i < 1000000; i++)
			{
				var tree = new Tree()
				{
					X = r.Next(0, 1000),
					Y = r.Next(0, 1000),
					Height = r.Next(1, 170)
				};

				var treeInfo = treeDataFactory.GetOrAddTreeInfo((TreeColor)r.Next(0, 7), (TreeType)r.Next(0, 7), (Mainland)r.Next(0, 8));
				tree.TreeInformation = treeInfo;
				forest.Add(tree);
			}
			
			Console.WriteLine(treeDataFactory.TreeInfoCount);
			Console.WriteLine(forest.Count/treeDataFactory.TreeInfoCount);

			//treeDataFactory.ShowAllTrees();
		}
	}
}
