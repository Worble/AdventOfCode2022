namespace Solutions.DaySeven.Inodes;

public class Inode
{
    public Inode(string name, int? size = null, Inode? parent = null)
    {
        Name = name;
        Size = size;
        Parent = parent;
    }
    public Inode? Parent { get; set; }
    public List<Inode> Children { get; set; } = new();
    public string Name { get; set; }
    public int? Size { get; set; }
    
    public InodeType InodeType => Size.HasValue ? InodeType.File : InodeType.Directory;

    public int GetDirectorySize()
    {
        if (InodeType == InodeType.File)
        {
            throw new Exception("Can not calculate directory size on a file");
        }

        var total = Children.Where(e => e.InodeType == InodeType.File).Select(e => e.Size ?? throw new Exception("File has no size")).Sum();
        total += Children.Where(e => e.InodeType == InodeType.Directory).Select(e => e.GetDirectorySize()).Sum();
        return total;
    }
}