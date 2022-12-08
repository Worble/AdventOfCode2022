namespace Solutions.DayTwo;

public class Shared
{
	public static readonly Dictionary<RPS, int> RpsScoreMap = new()
	{
		{RPS.Rock, 1},
		{RPS.Paper, 2},
		{RPS.Scissors, 3}
	};

	public static readonly Dictionary<Outcome, int> OutcomeScoreMap = new()
	{
		{Outcome.Draw, 3},
		{Outcome.Win, 6},
		{Outcome.Lose, 0}
	};
}