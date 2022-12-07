namespace Solutions.DayOne;

public static class Shared
{
    internal static IEnumerable<int> SetupElves(IEnumerable<string> split)
    {
        var calories = new List<int>();
        var currentCalories = 0;
        foreach (var line in split)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                calories.Add(currentCalories);
                currentCalories = 0;
                continue;
            }

            currentCalories += int.Parse(line);
        }

        calories.Add(currentCalories);
        return calories;
    }
}