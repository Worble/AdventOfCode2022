using System.Text;

namespace Solutions.DayThirteen;

public struct Packet : IComparable
{
	public Packet()
	{
		Type = PacketType.Int;
		Value = string.Empty;
	}

	public Packet(PacketType type, string value)
	{
		Type = type;
		Value = value;
	}

	private PacketType Type { get; set; }
	public string Value { get; set; }
	private int IntValue => string.IsNullOrWhiteSpace(Value) ? 0 : int.Parse(Value);

	private void ConvertToArray()
	{
		if (Type == PacketType.Array)
		{
			throw new Exception("Cannot convert array to array");
		}

		Type = PacketType.Array;
		Value = $"[{Value}]";
	}

	private static IEnumerable<Packet> GetValues(string input)
	{
		var sb = new StringBuilder();
		var brackets = 0;
		var current = new Packet();
		for (var i = 1; i < input.Length - 1; i++)
		{
			var c = input[i];

			switch (c)
			{
				case ',' when current.Type != PacketType.Array:
					if (sb.Length > 0)
					{
						yield return new Packet(current.Type, sb.ToString());
						sb = new StringBuilder();
						current = new Packet();
					}

					continue;
				case '[' when current.Type != PacketType.Array:
					current.Type = PacketType.Array;
					break;
				case '[':
					brackets++;
					break;
			}

			sb.Append(c);

			if (c != ']')
			{
				continue;
			}

			if (brackets < 1)
			{
				if (sb.Length > 0)
				{
					yield return new Packet(current.Type, sb.ToString());
					sb = new StringBuilder();
					current = new Packet();
				}
			}
			else
			{
				brackets--;
			}
		}

		if (sb.Length > 0)
		{
			yield return new Packet(current.Type, sb.ToString());
		}
	}

	public int CompareTo(object? obj)
	{
		var other = (Packet) (obj ?? throw new ArgumentNullException(nameof(obj)));
		switch (Type)
		{
			case PacketType.Int when other.Type == PacketType.Int:
			{
				if (IntValue < other.IntValue)
				{
					return 1;
				}

				return IntValue > other.IntValue
					? -1
					: 0;
			}
			case PacketType.Array when other.Type == PacketType.Int:
				other.ConvertToArray();
				break;
			case PacketType.Int when other.Type == PacketType.Array:
				ConvertToArray();
				break;
		}

		if (Type != PacketType.Array || other.Type != PacketType.Array)
		{
			throw new Exception("Unreachable code");
		}

		var thisValues = GetValues(Value).ToList();
		var rightValues = GetValues(other.Value).ToList();
		for (var i = 0; i < thisValues.Count; i++)
		{
			if (i >= rightValues.Count)
			{
				return -1;
			}

			var x = thisValues[i];
			var y = rightValues[i];
			switch (x.CompareTo(y))
			{
				case -1:
					return -1;
				case 1:
					return 1;
				case 0:
					continue;
				default:
					throw new Exception("Unknown comparison result");
			}
		}

		return thisValues.Count < rightValues.Count
			? 1
			: 0;
	}
}