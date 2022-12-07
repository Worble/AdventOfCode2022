using FluentAssertions;
using Solutions.DayFour;
using Xunit;

namespace Tests.DayFour;

public class PartTwoTests
{
    [Theory]
    [ClassData(typeof(PartTwoTestsData))]
    public void DuplicateAssignments(string input, int expected)
    {
        PartTwo.DuplicateAssignments(input).Should().Be(expected);
    }
}