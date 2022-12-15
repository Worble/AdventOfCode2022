using FluentAssertions;
using Solutions.DayFourteen;
using Xunit;

namespace Tests.DayFourteen;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void UnitsOfSand(string input, int expected)
	{
		PartTwo.UnitsOfSand(input).Should().Be(expected);
	}
}