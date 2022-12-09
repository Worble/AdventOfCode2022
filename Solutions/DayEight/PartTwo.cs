using Solutions.Extensions;

namespace Solutions.DayEight;

public static class PartTwo
{
	private static readonly List<Func<List<string>, int, int, int, int>> Actions = new()
	{
		// left
		(lines, currentTree, y, x) =>
		{
			var score = 0;
			for (var x2 = x - 1; x2 >= 0; x2--)
			{
				score++;
				if (lines[y][x2].ToInt() >= currentTree)
				{
					break;
				}
			}

			return score;
		},
		// right
		(lines, currentTree, y, x) =>
		{
			var score = 0;
			for (var x2 = x + 1; x2 < lines.Count; x2++)
			{
				score++;
				if (lines[y][x2].ToInt() >= currentTree)
				{
					break;
				}
			}

			return score;
		},
		// down
		(lines, currentTree, y, x) =>
		{
			var score = 0;
			for (var y2 = y - 1; y2 >= 0; y2--)
			{
				score++;
				if (lines[y2][x].ToInt() >= currentTree)
				{
					break;
				}
			}

			return score;
		},
		// up
		(lines, currentTree, y, x) =>
		{
			var score = 0;
			for (var y2 = y + 1; y2 < lines.Count; y2++)
			{
				score++;
				if (lines[y2][x].ToInt() >= currentTree)
				{
					break;
				}
			}

			return score;
		}
	};

	public static int ScenicScore(string input)
	{
		var lines = input.SplitNewlines().ToList();
		var scores = new List<int>();

		for (var y = 0; y < lines.Count; y++)
		{
			var line = lines[y];
			for (var x = 0; x < line.Length; x++)
			{
				var currentTree = line[x].ToInt();
				var directions = Actions.Select(action => action(lines, currentTree, y, x));
				scores.Add(directions.Aggregate((a, b) => a * b));
			}
		}

		return scores.Max();
	}
}