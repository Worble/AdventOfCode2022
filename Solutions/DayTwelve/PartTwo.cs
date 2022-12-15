using Solutions.Extensions;

namespace Solutions.DayTwelve;

public static class PartTwo
{
	public static int FindShortest(string input)
	{
		Node? root = null;
		var lines = input.SplitNewlines().ToList();
		var nodes = new Node[lines.Count, lines[0].Length];
		for (var y = 0; y < lines.Count; y++)
		{
			var line = lines[y];
			for (var x = 0; x < line.Length; x++)
			{
				var c = line[x];
				nodes[y, x] = new Node(c, y, x);
				if (c == 'E')
				{
					root = nodes[y, x];
				}
			}
		}

		var test = Shared.Bfs(root ?? throw new Exception(),
			nodes,
			currentHeight => currentHeight is 'a' or 'S',
			(adjacentHeight, currentHeight) => adjacentHeight + 1 >= currentHeight);
		return test.Steps;
	}
}