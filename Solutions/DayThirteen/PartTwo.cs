using Solutions.Extensions;

namespace Solutions.DayThirteen;

public static class PartTwo
{
	public static int DecoderKey(string input)
	{
		var packets = new List<Packet>(input
			.SplitNewlines(StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
			.Select(e => new Packet(PacketType.Array, e)))
		{
			new(PacketType.Array, "[[2]]"),
			new(PacketType.Array, "[[6]]")
		};
		packets.Sort();
		packets.Reverse();
		return (packets.FindIndex(e => e.Value == "[[2]]") + 1) * (packets.FindIndex(e => e.Value == "[[6]]") + 1);
	}
}