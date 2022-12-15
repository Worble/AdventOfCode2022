namespace Solutions.DayTwelve;

public class Shared
{
	public static Node Bfs(Node root, Node[,] nodes, Func<char, bool> target, Func<char, char, bool> comparison)
	{
		var q = new Queue<Node>();
		var visited = new List<Node>();
		q.Enqueue(root);
		while (q.Count > 0)
		{
			var current = q.Dequeue();
			if (target(current.Height))
			{
				return current;
			}

			var currentHeight = current.Height switch
			{
				'S' => 'a',
				'E' => 'z',
				_ => current.Height
			};

			var adjacentNodes = current.GetAdjacent(nodes).Where(
				e =>
				{
					var adjacentHeight = e.Height switch
					{
						'E' => 'z',
						'S' => 'a',
						_ => e.Height
					};
					return comparison(adjacentHeight, currentHeight) && !visited.Contains(e);
				});
			foreach (var node in adjacentNodes)
			{
				q.Enqueue(new Node(node.Height, node.Y, node.X, current.Steps));
				visited.Add(node);
			}
		}

		throw new Exception("Traversed entire tree without hitting exit");
	}
}