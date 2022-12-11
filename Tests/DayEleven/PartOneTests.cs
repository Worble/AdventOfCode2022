using FluentAssertions;
using Solutions.DayEleven;
using Xunit;

namespace Tests.DayEleven;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void MonkeyBusiness(string input, long expected)
	{
		PartOne.MonkeyBusiness(input).Should().Be(expected);
	}
}