using Solutions.DaySeven.Inodes;

namespace Solutions.DaySeven;

public static class PartTwo
{
    private const int MaxDiskSize = 70000000;
    private const int DiskSpaceNeeded = 30000000;
    public static int GetDirectorySizeToDelete(string input)
    {
        var fileSystem = Shared.ParseInput(input, out var root);
        var spaceNeeded = DiskSpaceNeeded - (MaxDiskSize - root.GetDirectorySize());
        var directoryToDelete = fileSystem.Where(e => e.InodeType == InodeType.Directory && e.GetDirectorySize() > spaceNeeded)
            .OrderBy(e => e.GetDirectorySize())
            .First();
        return directoryToDelete.GetDirectorySize();
    }
}