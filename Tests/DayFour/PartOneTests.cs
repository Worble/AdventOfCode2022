using FluentAssertions;
using Solutions.DayFour;
using Xunit;

namespace Tests.DayFour;

public class PartOneTests
{
    [Theory]
    [ClassData(typeof(PartOneTestsData))]
    public void DuplicateAssignments(string input, int expected)
    {
        PartOne.DuplicateAssignments(input).Should().Be(expected);
    }
}