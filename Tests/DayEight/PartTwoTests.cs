using FluentAssertions;
using Solutions.DayEight;
using Xunit;

namespace Tests.DayEight;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void DuplicateAssignments(string input, int expected)
	{
		PartTwo.ScenicScore(input).Should().Be(expected);
	}
}