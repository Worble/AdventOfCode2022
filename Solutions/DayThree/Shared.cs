namespace Solutions.DayThree;

public static class Shared
{
    public static readonly Dictionary<char, int> Priority = new();

    static Shared()
    {
        var priority = 1;
        for (var c = 'a'; c <= 'z'; c++)
        {
            Priority.Add(c, priority);
            Priority.Add(char.ToUpper(c), priority + 26);
            priority++;
        }
    }
}