namespace Solutions.DayEleven;

public class Monkey
{
	public Monkey(string[] input)
	{
		for (var i = 0; i < input.Length - 2; i++)
		{
			var index = i;
			var line = input[index];
			switch (index)
			{
				case 0:
					Number = long.Parse(line.Split(" ").Last()[..^1]);
					break;
				case 1:
					Items = line.Split(":")[1]
						.Split(",", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
						.Select(long.Parse).ToList();
					break;
				case 2:
					Operation = old =>
					{
						Inspected++;
						var split = line.Split(" ")[^2..];
						var variable = string.Equals(split[1], "old", StringComparison.InvariantCultureIgnoreCase)
							? old
							: long.Parse(split[1]);
						return split[0] switch
						{
							"*" => old * variable,
							"+" => old + variable,
							_ => throw new Exception($"Could not parse operator {split[0]}")
						};
					};
					break;
				case 3:
					TestNum = int.Parse(line.Split(" ")[^1]);
					Test = item => long.Parse(item % long.Parse(line.Split(" ")[^1]) == 0
						? input[index + 1].Split(" ").Last()
						: input[index + 2].Split(" ").Last()
					);
					break;
				default:
					throw new Exception(
						$"Input has too many lines:{Environment.NewLine}{string.Join(Environment.NewLine, input)}");
			}
		}
	}

	public int TestNum { get; }

	public long Number { get; }
	public List<long> Items { get; }
	public Func<long, long> Operation { get; }
	public Func<long, long> Test { get; }

	public long Inspected { get; private set; }
}