namespace Solutions.DayTen;

public class AddX : IInstruction
{
	public AddX(int v)
	{
		V = v;
	}

	public int Cycles => 2;
	public int V { get; }
}