using FluentAssertions;
using Solutions.DayEight;
using Xunit;

namespace Tests.DayEight;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void DuplicateAssignments(string input, int expected)
	{
		PartOne.VisibleTrees(input).Should().Be(expected);
	}
}