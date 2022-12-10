namespace Solutions.DayTen;

public static class InstructionFactory
{
	public static IInstruction Create(string instruction)
	{
		var split = instruction.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
		return split[0] switch
		{
			"noop" => new NoOp(),
			"addx" => new AddX(int.Parse(split[1])),
			_ => throw new Exception($"Could not parse instruction {instruction}")
		};
	}
}