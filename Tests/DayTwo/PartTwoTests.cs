using FluentAssertions;
using Solutions.DayTwo;
using Xunit;

namespace Tests.DayTwo;

public class PartTwpTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void GetScore(string input, int expected)
	{
		PartTwo.GetScore(input).Should().Be(expected);
	}
}