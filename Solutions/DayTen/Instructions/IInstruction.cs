namespace Solutions.DayTen;

public interface IInstruction
{
	int Cycles { get; }
	int V { get; }
}