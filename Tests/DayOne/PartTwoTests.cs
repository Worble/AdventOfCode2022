using FluentAssertions;
using Solutions.DayOne;
using Xunit;

namespace Tests.DayOne;

public class PartTwoTests
{
    [Theory]
    [ClassData(typeof(PartTwoTestsData))]
    public void GetHighestThreeCalories(string input, int expected)
    {
        PartTwo.GetHighestThreeCalories(input).Should().Be(expected);
    }
}