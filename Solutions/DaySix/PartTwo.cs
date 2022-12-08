namespace Solutions.DaySix;

public static class PartTwo
{
	public static int FindStartOfMessageMarker(string input)
	{
		return Shared.FindOffset(input, 13);
	}
}