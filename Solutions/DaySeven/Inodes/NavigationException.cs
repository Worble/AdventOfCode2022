using System.Text.Json;

namespace Solutions.DaySeven.Inodes;

public class NavigationException : Exception
{
    public NavigationException(string line, Inode current, Inode root):base($"Tried to navigate up a node that doesn't exist\nLine was {line}\nCurrent was: {JsonSerializer.Serialize(current)}\nTree was {JsonSerializer.Serialize(root)}")
    {
        Line = line;
        Current = current;
        Root = root;
    }

    public Inode Root { get; }

    public Inode Current { get; }

    public string Line { get; }
}