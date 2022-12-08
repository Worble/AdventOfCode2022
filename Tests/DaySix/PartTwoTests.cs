using FluentAssertions;
using Solutions.DaySix;
using Xunit;

namespace Tests.DaySix;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void FindStartOfPacketMarker(string input, int expected)
	{
		PartTwo.FindStartOfMessageMarker(input).Should().Be(expected);
	}
}