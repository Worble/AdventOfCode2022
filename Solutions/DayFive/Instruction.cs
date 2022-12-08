namespace Solutions.DayFive;

public struct Instruction
{
	public Instruction(IReadOnlyList<string> input)
	{
		Amount = int.Parse(input[1]);
		From = int.Parse(input[3]);
		To = int.Parse(input[5]);
	}

	public int To { get; }

	public int From { get; }

	public int Amount { get; }
}