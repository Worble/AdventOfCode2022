namespace Solutions.DayFour;

public struct Assignment
{
	public Assignment(string input)
	{
		var split = input.Split('-');
		LowerSection = int.Parse(split[0]);
		UpperSection = int.Parse(split[1]);
	}

	public int LowerSection { get; }
	public int UpperSection { get; }
}