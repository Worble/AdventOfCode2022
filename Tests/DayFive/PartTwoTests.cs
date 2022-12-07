using FluentAssertions;
using Solutions.DayFive;
using Xunit;

namespace Tests.DayFive;

public class PartTwoTests
{
    [Theory]
    [ClassData(typeof(PartTwoTestsData))]
    public void DuplicateAssignments(string input, string expected)
    {
        PartTwo.GetTopCrates(input).Should().Be(expected);
    }
}