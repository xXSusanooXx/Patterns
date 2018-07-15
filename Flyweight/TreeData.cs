namespace Flyweight
{
	public class TreeInformation
	{
		public TreeColor Color { get; set; }
		public TreeType TreeType { get; set; }
		public Mainland Mainland { get; set; }
	}

	public enum TreeType
	{
		Oak = 1,
		Birch = 2,
		Maple = 3,
		Pear = 4,
		Chestnut = 5,
		Hazel = 6
	}

	public enum TreeColor
	{
		Yellow = 1,
		Red,
		Green,
		Orange,
		Grey,
		Brown
	}

	public enum Mainland
	{
		Europe = 1,
		Asia,
		NorthAmerica,
		SouthAmerica,
		Africa,
		Antarctica,
		Atlantis
	}

}
