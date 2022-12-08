namespace Solutions.DaySix;

public static class PartOne
{
	public static int FindStartOfPacketMarker(string input)
	{
		return Shared.FindOffset(input, 3);
	}
}