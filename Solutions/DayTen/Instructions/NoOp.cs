namespace Solutions.DayTen;

public class NoOp : IInstruction
{
	public int Cycles => 1;
	public int V => 0;
}