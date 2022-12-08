using Solutions.Extensions;

namespace Solutions.DayOne;

public static class PartTwo
{
	public static int GetHighestThreeCalories(string input)
	{
		var split = input.SplitNewlines();
		return Shared.SetupElves(split)
			.OrderByDescending(e => e)
			.Take(3)
			.Sum();
	}
}