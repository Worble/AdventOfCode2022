using FluentAssertions;
using Solutions.DayFourteen;
using Xunit;

namespace Tests.DayFourteen;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void UnitsOfSand(string input, int expected)
	{
		PartOne.UnitsOfSand(input).Should().Be(expected);
	}
}