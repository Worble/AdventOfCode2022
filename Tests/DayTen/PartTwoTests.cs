using FluentAssertions;
using Solutions.DayTen;
using Xunit;

namespace Tests.DayTen;

public class PartTwoTests
{
	[Theory]
	[ClassData(typeof(PartTwoTestsData))]
	public void FindStartOfPacketMarker(string input, string expected)
	{
		PartTwo.DrawPixels(input).Should().Be(expected);
	}
}