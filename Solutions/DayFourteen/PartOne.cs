using System.Drawing;
using Solutions.Extensions;

namespace Solutions.DayFourteen;

public static class PartOne
{
	public static int UnitsOfSand(string input)
	{
		var lines = input.SplitNewlines();
		
		var rocks = Shared.GenerateRocks(lines);
		for (var i = 1;; i++)
		{
			var sand = new Point(500, 0);
			while (true)
			{
				if (sand.Y > rocks.MaxBy(e => e.Y).Y)
				{
					return i-1;
				}
				
				sand.Offset(0, 1);
				if (rocks.All(e => e != sand))
				{
					continue;
				}
				sand.Offset(-1,0);
				if (rocks.All(e => e != sand))
				{
					continue;
				}
				sand.Offset(2,0);
				if (rocks.All(e => e != sand))
				{
					continue;
				}
				sand.Offset(-1,-1);
				if (sand == new Point(500, 0))
				{
					return i;
				}
				rocks.Add(sand);
				break;
			}
		}
	}

	
}