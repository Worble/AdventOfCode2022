using Solutions.Extensions;

namespace Solutions.DayThree;

public static class PartTwo
{
	public static int BadgePriority(string input)
	{
		var lines = input.SplitNewlines().ToArray();

		var currentList = new List<string>();
		var total = 0;
		for (var i = 0; i < lines.Length; i++)
		{
			if (i != 0 && i % 3 == 0)
			{
				total += GetPriority(currentList);
				currentList = new List<string>();
			}

			currentList.Add(lines[i]);
		}

		total += GetPriority(currentList);
		return total;
	}

	private static int GetPriority(IReadOnlyCollection<string> currentList)
	{
		var badge = currentList
			.Skip(1)
			.Aggregate(
				new HashSet<char>(currentList.First()),
				(h, e) =>
				{
					h.IntersectWith(e);
					return h;
				}
			).First();
		return Shared.Priority[badge];
	}
}