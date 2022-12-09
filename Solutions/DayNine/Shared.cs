using System.Drawing;
using Solutions.Extensions;

namespace Solutions.DayNine;

public static class Shared
{
	private static readonly List<Func<Point, Point>> Offsets = new()
	{
		difference => difference.Y > 1 ? new Point(0, -1) : default,
		difference => difference.Y < -1 ? new Point(0, 1) : default,
		difference => difference.X > 1 ? new Point(-1, 0) : default,
		difference => difference.X < -1 ? new Point(1, 0) : default
	};

	private static IEnumerable<Point> ParseLine(string line)
	{
		var split = line.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
		var times = int.Parse(split[1]);
		return split[0] switch
		{
			"R" => Enumerable.Repeat(new Point(1, 0), times),
			"U" => Enumerable.Repeat(new Point(0, 1), times),
			"L" => Enumerable.Repeat(new Point(-1, 0), times),
			"D" => Enumerable.Repeat(new Point(0, -1), times),
			_ => throw new Exception($"Could not parse line {line}")
		};
	}

	public static int PositionsVisited(string input, int tailLength)
	{
		var lines = input.SplitNewlines().SelectMany(ParseLine);
		var head = new Point(0, 0);
		var tails = Enumerable.Repeat(new Point(0, 0), tailLength).ToList();
		var visited = new HashSet<Point> {tails.Last()};
		foreach (var line in lines)
		{
			head.Offset(line);
			var prev = head;

			for (var i = 0; i < tails.Count; i++)
			{
				var tail = tails[i];
				var difference = new Point(prev.X - tail.X, prev.Y - tail.Y);
				if (Math.Abs(difference.X) > 1 || Math.Abs(difference.Y) > 1)
				{
					foreach (var offset in Offsets)
					{
						difference.Offset(offset(difference));
					}

					tail.Offset(difference);
				}

				prev = tail;
				tails[i] = tail;
			}

			visited.Add(tails.Last());
		}

		return visited.Count;
	}
}