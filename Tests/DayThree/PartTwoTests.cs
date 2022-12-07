using FluentAssertions;
using Solutions.DayThree;
using Xunit;

namespace Tests.DayThree;

public class PartTwoTests
{
    [Theory]
    [ClassData(typeof(PartTwoTestsData))]
    public void GetSharedItemPriority(string input, int expected)
    {
        PartTwo.BadgePriority(input).Should().Be(expected);
    }
}