using FluentAssertions;
using Solutions.DayTwelve;
using Xunit;

namespace Tests.DayTwelve;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void FindShortest(string input, int expected)
	{
		PartOne.FindShortest(input).Should().Be(expected);
	}
}