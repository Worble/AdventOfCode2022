using FluentAssertions;
using Solutions.DayTwelve;
using Xunit;

namespace Tests.DayTwelve;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void FindShortest(string input, int expected)
	{
		PartTwo.FindShortest(input).Should().Be(expected);
	}
}