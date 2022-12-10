using FluentAssertions;
using Solutions.DayTen;
using Xunit;

namespace Tests.DayTen;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void FindStartOfPacketMarker(string input, int expected)
	{
		PartOne.SumSignalStrengths(input).Should().Be(expected);
	}
}