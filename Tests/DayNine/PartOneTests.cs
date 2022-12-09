using FluentAssertions;
using Solutions.DayNine;
using Xunit;

namespace Tests.DayNine;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void DuplicateAssignments(string input, int expected)
	{
		PartOne.PositionsVisited(input).Should().Be(expected);
	}
}