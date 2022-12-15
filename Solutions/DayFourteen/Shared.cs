using System.Drawing;

namespace Solutions.DayFourteen;

public static class Shared
{
	public static HashSet<Point> GenerateRocks(IEnumerable<string> lines)
	{
		var rocks = new HashSet<Point>();
		foreach (var line in lines)
		{
			var rockFormations = line.Split("->", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
			var old = Parse(rockFormations.First());
			rocks.Add(old);
			foreach (var rockFormation in rockFormations.Skip(1))
			{
				var current = Parse(rockFormation);
				var xChange = current.X != old.X;
				var i = xChange ? old.X : old.Y;
				var target = xChange ? current.X : current.Y;
				var isUp = i < target;
				if (isUp)
				{
					i++;
				}
				else
				{
					i--;
				}

				while (isUp ? i <= target : i >= target)
				{
					rocks.Add(new Point(xChange ? i : old.X, xChange ? old.Y : i));
					if (isUp)
					{
						i++;
					}
					else
					{
						i--;
					}
				}

				old = current;
			}
		}

		return rocks;
	}

	private static Point Parse(string input)
	{
		var first = input.Split(",", StringSplitOptions.TrimEntries);
		return new Point(int.Parse(first[0]), int.Parse(first[1]));
	}
}