using FluentAssertions;
using Solutions.DaySeven;
using Xunit;

namespace Tests.DaySeven;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void GetTotalUnderAmount(string input, int expected)
	{
		PartTwo.GetDirectorySizeToDelete(input).Should().Be(expected);
	}
}