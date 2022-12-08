using Solutions.Extensions;

namespace Solutions.DayEight;

public static class PartOne
{
	private static readonly List<Func<List<string>, int, int, int, bool>> Actions = new()
	{
		(lines, currentTree, y, x) => lines[y][..x].All(e => e.ToInt() < currentTree),
		(lines, currentTree, y, x) => lines[y][(x + 1)..].All(e => e.ToInt() < currentTree),
		(lines, currentTree, y, x) =>
		{
			var trees = new List<char>();
			for (var y2 = y - 1; y2 >= 0; y2--)
			{
				trees.Add(lines[y2][x]);
			}

			return trees.All(e => e.ToInt() < currentTree);
		},
		(lines, currentTree, y, x) =>
		{
			var trees = new List<char>();
			for (var y2 = y + 1; y2 < lines.Count; y2++)
			{
				trees.Add(lines[y2][x]);
			}

			return trees.All(e => e.ToInt() < currentTree);
		},
	};

	public static int VisibleTrees(string input)
	{
		var lines = input.SplitNewlines().ToList();
		var count = lines[0].Length * 2 + (lines.Count - 2) * 2;
		for (var y = 1; y < lines.Count - 1; y++)
		{
			var line = lines[y];
			for (var x = 1; x < line.Length - 1; x++)
			{
				var currentTree = line[x].ToInt();
				if (Actions.Any(action => action(lines, currentTree, y, x)))
				{
					count++;
				}
			}
		}

		return count;
	}
}