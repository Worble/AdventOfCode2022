using Solutions.Extensions;

namespace Solutions.DayThree;

public static class PartOne
{
    public static int SharedItemPriority(string input)
    {
        var lines = input.SplitNewlines();
        return lines.Sum(line =>
            Shared.Priority[line[..(line.Length / 2)]
                .Intersect(line[(line.Length / 2)..])
                .First()
            ]
        );
    }
}