using FluentAssertions;
using Solutions.DayThirteen;
using Xunit;

namespace Tests.DayThirteen;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void DecoderKey(string input, int expected)
	{
		PartTwo.DecoderKey(input).Should().Be(expected);
	}
}