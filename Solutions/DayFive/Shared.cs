using Solutions.Extensions;

namespace Solutions.DayFive;

public static class Shared
{
	public static Dictionary<int, SortedList<int, char>> CreateCrateStacks(List<string> lines)
	{
		var crateStacks = new Dictionary<int, SortedList<int, char>>();
		for (var i = FindDrawingSplitIndex(lines) - 1; i >= 0; i--)
		{
			var line = lines[i];
			var stack = 1;
			for (var y = 1; y < line.Length; y += 4, stack++)
			{
				var crate = line[y];
				if (!crateStacks.TryGetValue(stack, out var crates))
				{
					crates = new SortedList<int, char>();
					crateStacks.Add(stack, crates);
				}

				if (crate == ' ')
				{
					continue;
				}

				var index = crates.Count > 0 ? crates.Keys.Max() + 1 : 0;
				crates.Add(index, crate);
			}
		}

		return crateStacks;
	}

	public static int FindDrawingSplitIndex(List<string> lines)
	{
		return lines.FindIndex(line => line.Length > 1 && int.TryParse(line[1].ToString(), out _));
	}

	public static IEnumerable<Instruction> ParseInstructions(List<string> lines)
	{
		var startIndex = FindDrawingSplitIndex(lines) + 1;
		lines = lines.GetRange(startIndex..);
		return lines.Select(line => new Instruction(line.Split(' ')));
	}
}