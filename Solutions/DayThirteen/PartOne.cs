using Solutions.Extensions;

namespace Solutions.DayThirteen;

public static class PartOne
{
	public static int PairIndicesSum(string input)
	{
		var lines = input.SplitNewlines().ToList();
		var total = 0;
		var index = 1;
		for (var i = 0; i < lines.Count; i+=3, index++)
		{
			var left = new Packet(PacketType.Array, lines[i]);
			var right = new Packet(PacketType.Array, lines[i+1]);
			if (left.CompareTo(right) == 1)
			{
				total+=index;
			}
		}

		return total;
	} 
}