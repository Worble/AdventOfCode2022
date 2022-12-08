namespace Solutions.DaySeven.Inodes;

public class Inode
{
	private int? _cachedSize;

	public Inode(string name, int? size = null, Inode? parent = null)
	{
		Name = name;
		Size = size;
		Parent = parent;
	}

	public Inode? Parent { get; }
	public List<Inode> Children { get; } = new();
	public string Name { get; }
	private int? Size { get; }

	public InodeType InodeType => Size.HasValue ? InodeType.File : InodeType.Directory;

	public int GetDirectorySize()
	{
		if (_cachedSize.HasValue)
		{
			return _cachedSize.Value;
		}

		if (InodeType == InodeType.File)
		{
			throw new Exception("Can not calculate directory size on a file");
		}

		var total = Children.Where(e => e.InodeType == InodeType.File)
			.Select(e => e.Size ?? throw new Exception("File has no size"))
			.Sum();
		total += Children.Where(e => e.InodeType == InodeType.Directory)
			.Select(e => e.GetDirectorySize())
			.Sum();
		_cachedSize = total;
		return total;
	}
}