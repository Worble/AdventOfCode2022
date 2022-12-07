using FluentAssertions;
using Solutions.DayThree;
using Xunit;

namespace Tests.DayThree;

public class PartOneTests
{
    [Theory]
    [ClassData(typeof(PartOneTestsData))]
    public void GetSharedItemPriority(string input, int expected)
    {
        PartOne.SharedItemPriority(input).Should().Be(expected);
    }
}