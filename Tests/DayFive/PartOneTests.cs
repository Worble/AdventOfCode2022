using FluentAssertions;
using Solutions.DayFive;
using Xunit;

namespace Tests.DayFive;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void DuplicateAssignments(string input, string expected)
	{
		PartOne.GetTopCrates(input).Should().Be(expected);
	}
}