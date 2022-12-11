using Solutions.Extensions;

namespace Solutions.DayEleven;

public static class PartTwo
{
	public static long MonkeyBusiness(string input)
	{
		var monkeys = input.SplitNewlines(StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
			.Chunk(6)
			.Select(e => new Monkey(e))
			.ToList();

		for (var round = 0; round < 10000; round++)
		{
			foreach (var monkey in monkeys)
			{
				for (var itemIndex = 0; itemIndex < monkey.Items.Count; itemIndex++)
				{
					var item = monkey.Items[itemIndex];
					var newVal = monkey.Operation(item);
					newVal %= monkeys.Aggregate(1, (i, monkeyAgg) => i * monkeyAgg.TestNum);
					var monkeyTo = monkey.Test(newVal);
					monkey.Items.RemoveAt(itemIndex);
					itemIndex--;
					monkeys.First(e => e.Number == monkeyTo).Items.Add(newVal);
				}
			}
		}

		return monkeys.Select(e => e.Inspected)
			.OrderByDescending(e => e)
			.Take(2)
			.Aggregate((a, b) => a * b);
	}
}