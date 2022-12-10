using System.Text;
using Solutions.Extensions;

namespace Solutions.DayTen;

public static class PartTwo
{
	public static string DrawPixels(string input)
	{
		var instructions = input.SplitNewlines().Select(InstructionFactory.Create).ToList();
		return new Cpu(instructions).Process();
	}

	private class Cpu
	{
		private readonly List<IInstruction> _instructions;


		private readonly List<string> _pixelRows = new()
		{
			"........................................",
			"........................................",
			"........................................",
			"........................................",
			"........................................",
			"........................................"
		};

		private int _cycle = 1;
		private int _x;

		public Cpu(List<IInstruction> instructions)
		{
			_instructions = instructions;
		}

		private IEnumerable<int> XRange => Enumerable.Range(_x, 3);

		public string Process()
		{
			int? runat = null;
			for (var i = 0; i < _instructions.Count;)
			{
				var instruction = _instructions[i];

				runat ??= _cycle + (instruction.Cycles - 1);

				var pixelRowIndex = (_cycle - 1) / 40;
				var pixelRow = _pixelRows[pixelRowIndex];
				var pixelRowCharacterIndex = _cycle - pixelRowIndex * 40 - 1;
				if (XRange.Contains(pixelRowCharacterIndex))
				{
					_pixelRows[pixelRowIndex] = new StringBuilder(pixelRow)
					{
						[pixelRowCharacterIndex] = '#'
					}.ToString();
				}

				if (runat == _cycle)
				{
					_x += instruction.V;
					runat = null;
					i++;
				}

				_cycle++;
			}

			return _pixelRows.Aggregate((a, b) => $"{a}{Environment.NewLine}{b}");
		}
	}
}

