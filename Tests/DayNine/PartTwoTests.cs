using FluentAssertions;
using Solutions.DayNine;
using Xunit;

namespace Tests.DayNine;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void DuplicateAssignments(string input, int expected)
	{
		PartTwo.PositionsVisited(input).Should().Be(expected);
	}
}