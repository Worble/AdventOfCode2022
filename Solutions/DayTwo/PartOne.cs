using Solutions.Extensions;

namespace Solutions.DayTwo;

public class PartOne
{
	private static readonly Dictionary<char, RPS> RpsMap = new()
	{
		{'A', RPS.Rock},
		{'X', RPS.Rock},
		{'B', RPS.Paper},
		{'Y', RPS.Paper},
		{'C', RPS.Scissors},
		{'Z', RPS.Scissors}
	};

	private static readonly Dictionary<(RPS opponent, RPS me), Outcome> WinMap = new()
	{
		{(RPS.Rock, RPS.Rock), Outcome.Draw},
		{(RPS.Rock, RPS.Paper), Outcome.Win},
		{(RPS.Rock, RPS.Scissors), Outcome.Lose},
		{(RPS.Paper, RPS.Rock), Outcome.Lose},
		{(RPS.Paper, RPS.Paper), Outcome.Draw},
		{(RPS.Paper, RPS.Scissors), Outcome.Win},
		{(RPS.Scissors, RPS.Rock), Outcome.Win},
		{(RPS.Scissors, RPS.Paper), Outcome.Lose},
		{(RPS.Scissors, RPS.Scissors), Outcome.Draw}
	};

	public static int GetScore(string input)
	{
		return input.SplitNewlines().Sum(line =>
			Shared.RpsScoreMap[RpsMap[line[2]]] +
			Shared.OutcomeScoreMap[WinMap[(RpsMap[line[0]], RpsMap[line[2]])]]
		);
	}
}