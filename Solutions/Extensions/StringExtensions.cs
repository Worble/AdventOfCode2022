namespace Solutions.Extensions;

public static class StringExtensions
{
	public static IEnumerable<string> SplitNewlines(this string input,
		StringSplitOptions stringSplitOptions = StringSplitOptions.TrimEntries)
	{
		return input.Split(new[] {"\n", "\r\n"}, stringSplitOptions);
	}
}