using Solutions.Extensions;

namespace Solutions.DayOne;

public static class PartOne
{
    public static int GetHighestCalories(string input)
    {
        var split = input.SplitNewlines();
        return Shared.SetupElves(split).Max();
    }
}