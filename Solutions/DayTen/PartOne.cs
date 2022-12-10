using Solutions.Extensions;

namespace Solutions.DayTen;

public static class PartOne
{
	public static int SumSignalStrengths(string input)
	{
		var instructions = input.SplitNewlines().Select(InstructionFactory.Create).ToList();
		return new Cpu(instructions).Process().Sum();
	}

	private class Cpu
	{
		private static readonly List<int> CycleReports = new()
		{
			20, 60, 100, 140, 180, 220
		};

		private readonly List<IInstruction> _instructions;
		private int _cycle = 1;
		private int _x = 1;

		public Cpu(List<IInstruction> instructions)
		{
			_instructions = instructions;
		}

		public IEnumerable<int> Process()
		{
			int? runat = null;
			for (var i = 0; i < _instructions.Count;)
			{
				var instruction = _instructions[i];

				runat ??= _cycle + (instruction.Cycles - 1);

				if (CycleReports.Contains(_cycle))
				{
					yield return _x * _cycle;
				}

				if (runat == _cycle)
				{
					_x += instruction.V;
					runat = null;
					i++;
				}

				_cycle++;
			}
		}
	}
}

