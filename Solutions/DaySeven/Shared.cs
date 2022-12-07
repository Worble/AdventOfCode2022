using Solutions.DaySeven.Inodes;
using Solutions.Extensions;

namespace Solutions.DaySeven;

public static class Shared
{
    public static List<Inode> ParseInput(string input, out Inode root)
    {
        root = new Inode("/");
        
        var all = new List<Inode>{root};
        var current = root;
        
        var lines = input.SplitNewlines();
        foreach (var line in lines.Skip(1))
        {
            var split = line.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            
            if (line[0] == '$')
            {
                current = split[1] switch
                {
                    "cd" => split[2] switch
                    {
                        ".." => current.Parent ?? throw new NavigationException(line, current, root),
                        _ => current.Children.First(e => e.Name == split[2])
                    },
                    _ => current
                };
                continue;
            }

            int? fileSize = int.TryParse(split[0], out var size) ? size : null;
            var inode = new Inode(split[1], fileSize, current);
            current.Children.Add(inode);
            all.Add(inode);
        }

        return all;
    }
}