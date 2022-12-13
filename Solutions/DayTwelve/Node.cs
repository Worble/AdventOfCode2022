namespace Solutions.DayTwelve;

public class Node
{
	public Node(char height, int y, int x, int? previousSteps = null)
	{
		Height = height;
		X = x;
		Y = y;
		Steps = previousSteps + 1 ?? 0;
	}

	public List<Node> Previous { get; } = new();

	public int Steps { get; }
	public int X { get; }
	public int Y { get; }
	public char Height { get; }

	protected bool Equals(Node other)
	{
		return X == other.X && Y == other.Y;
	}

	public override bool Equals(object? obj)
	{
		if (ReferenceEquals(null, obj))
		{
			return false;
		}

		if (ReferenceEquals(this, obj))
		{
			return true;
		}

		return obj.GetType() == GetType() && Equals((Node) obj);
	}

	public IEnumerable<Node> GetAdjacent(Node[,] nodes)
	{
		var adjacents = new List<(int y, int x)>
		{
			(Y, X - 1), (Y - 1, X), (Y, X + 1), (Y + 1, X)
		};
		foreach (var adjacent in adjacents.Where(adjacent => adjacent.y >= 0
		                                                     && adjacent.y < nodes.GetLength(0)
		                                                     && adjacent.x >= 0
		                                                     && adjacent.x < nodes.GetLength(1)))
		{
			yield return nodes[adjacent.y, adjacent.x];
		}
	}

	public override int GetHashCode()
	{
		return HashCode.Combine(X, Y);
	}
}