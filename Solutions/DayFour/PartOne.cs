using Solutions.Extensions;

namespace Solutions.DayFour;

public static class PartOne
{
    public static int DuplicateAssignments(string input)
    {
        var lines = input.SplitNewlines();
        return lines.Count(IsDuplicate);
    }

    private static bool IsDuplicate(string input)
    {
        var assignments = input
            .Split(',')
            .Select(e => new Assignment(e))
            .OrderBy(e => e.LowerSection)
            .ThenByDescending(e => e.UpperSection).ToArray();
        return assignments[0].UpperSection >= assignments[1].UpperSection;
    }
}