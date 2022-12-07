using FluentAssertions;
using Solutions.DayTwo;
using Xunit;

namespace Tests.DayTwo;

public class PartOneTests
{
    [Theory]
    [ClassData(typeof(PartOneTestsData))]
    public void GetScore(string input, int expected)
    {
        PartOne.GetScore(input).Should().Be(expected);
    }
}