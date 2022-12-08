using FluentAssertions;
using Solutions.DaySix;
using Xunit;

namespace Tests.DaySix;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void FindStartOfPacketMarker(string input, int expected)
	{
		PartOne.FindStartOfPacketMarker(input).Should().Be(expected);
	}
}