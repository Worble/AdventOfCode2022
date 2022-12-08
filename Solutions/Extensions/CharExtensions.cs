namespace Solutions.Extensions;

public static class CharExtensions
{
	public static int ToInt(this char c)
	{
		return int.Parse(c.ToString());
	}
}