using FluentAssertions;
using Solutions.DaySeven;
using Xunit;

namespace Tests.DaySeven;

public class PartOneTests
{
    [Theory]
    [ClassData(typeof(PartOneTestsData))]
    public void GetTotalUnderAmount(string input, int expected)
    {
        PartOne.GetTotalUnderAmount(input, 100000).Should().Be(expected);
    }
}