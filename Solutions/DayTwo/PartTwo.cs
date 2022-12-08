using Solutions.Extensions;

namespace Solutions.DayTwo;

public class PartTwo
{
	private static readonly Dictionary<char, RPS> RpsMap = new()
	{
		{'A', RPS.Rock},
		{'B', RPS.Paper},
		{'C', RPS.Scissors}
	};

	private static readonly Dictionary<char, Outcome> OutcomeMap = new()
	{
		{'X', Outcome.Lose},
		{'Y', Outcome.Draw},
		{'Z', Outcome.Win}
	};

	private static readonly Dictionary<(RPS opponent, Outcome outcome), RPS> MoveMap = new()
	{
		{(RPS.Rock, Outcome.Win), RPS.Paper},
		{(RPS.Rock, Outcome.Lose), RPS.Scissors},
		{(RPS.Rock, Outcome.Draw), RPS.Rock},
		{(RPS.Paper, Outcome.Win), RPS.Scissors},
		{(RPS.Paper, Outcome.Lose), RPS.Rock},
		{(RPS.Paper, Outcome.Draw), RPS.Paper},
		{(RPS.Scissors, Outcome.Win), RPS.Rock},
		{(RPS.Scissors, Outcome.Lose), RPS.Paper},
		{(RPS.Scissors, Outcome.Draw), RPS.Scissors}
	};

	public static int GetScore(string input)
	{
		return input.SplitNewlines().Sum(line =>
			Shared.RpsScoreMap[MoveMap[(RpsMap[line[0]], OutcomeMap[line[2]])]] +
			Shared.OutcomeScoreMap[OutcomeMap[line[2]]]
		);
	}
}