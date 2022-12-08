using Solutions.DaySeven.Inodes;

namespace Solutions.DaySeven;

public static class PartOne
{
	public static int GetTotalUnderAmount(string input, int amount)
	{
		var fileSystem = Shared.ParseInput(input, out _);
		return fileSystem
			.Where(e => e.InodeType == InodeType.Directory && e.GetDirectorySize() < amount)
			.Select(e => e.GetDirectorySize())
			.Sum();
	}
}