using Solutions.Extensions;

namespace Solutions.DayFour;

public static class PartTwo
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
        var comparisons = new[] {assignments[1].LowerSection, assignments[1].UpperSection};
        return comparisons.Any(e =>
            e >= assignments[0].LowerSection && assignments[1].LowerSection <= assignments[0].UpperSection);
    }
}