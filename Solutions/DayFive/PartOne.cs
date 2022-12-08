using Solutions.Extensions;

namespace Solutions.DayFive;

public static class PartOne
{
	public static string GetTopCrates(string input)
	{
		var lines = input.SplitNewlines(StringSplitOptions.RemoveEmptyEntries).ToList();
		var crateStacks = Shared.CreateCrateStacks(lines);
		var instructions = Shared.ParseInstructions(lines);
		foreach (var instruction in instructions)
		{
			for (var i = 0; i < instruction.Amount; i++)
			{
				var from = crateStacks[instruction.From];
				var to = crateStacks[instruction.To];
				var fromMax = from.Keys.Max();
				var crate = from[from.Keys.Max()];
				from.Remove(fromMax);
				var toMax = to.Count > 0 ? to.Keys.Max() + 1 : 0;
				to.Add(toMax, crate);
			}
		}

		return new string(crateStacks.Select(kvp => kvp.Value[kvp.Value.Keys.Max()]).ToArray());
	}
}