namespace Solutions.DaySix;

public static class Shared
{
	public static int FindOffset(string input, int offset)
	{
		for (var i = offset; i < input.Length; i++)
		{
			var rangeStart = i - offset;
			var rangeEnd = i + 1;
			var range = input[rangeStart..rangeEnd].ToList().GroupBy(e => e);
			if (!range.Any(e => e.Count() > 1))
			{
				return i + 1;
			}
		}

		throw new Exception();
	}
}