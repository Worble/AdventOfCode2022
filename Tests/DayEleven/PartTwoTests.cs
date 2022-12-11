using FluentAssertions;
using Solutions.DayEleven;
using Xunit;

namespace Tests.DayEleven;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void MonkeyBusiness(string input, long expected)
	{
		PartTwo.MonkeyBusiness(input).Should().Be(expected);
	}
}