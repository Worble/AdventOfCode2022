using FluentAssertions;
using Solutions.DayOne;
using Xunit;

namespace Tests.DayOne;

public class PartOneTests
{
    [Theory]
    [ClassData(typeof(PartOneTestsData))]
    public void GetHighestCalories(string input, int expected)
    {
        PartOne.GetHighestCalories(input).Should().Be(expected);
    }
}