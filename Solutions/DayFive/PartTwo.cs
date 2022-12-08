using Solutions.Extensions;

namespace Solutions.DayFive;

public static class PartTwo
{
	public static string GetTopCrates(string input)
	{
		var lines = input.SplitNewlines(StringSplitOptions.RemoveEmptyEntries).ToList();
		var crateStacks = Shared.CreateCrateStacks(lines);
		var instructions = Shared.ParseInstructions(lines);
		foreach (var instruction in instructions)
		{
			var from = crateStacks[instruction.From];
			var to = crateStacks[instruction.To];

			var x = from.ToArray()[(from.Count - instruction.Amount)..];
			foreach (var (key, value) in x)
			{
				from.Remove(key);
				var toMax = to.Count > 0 ? to.Keys.Max() + 1 : 0;
				to.Add(toMax, value);
			}
		}

		return new string(crateStacks.Select(kvp => kvp.Value[kvp.Value.Keys.Max()]).ToArray());
	}
}