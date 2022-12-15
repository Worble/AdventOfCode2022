using System;
using System.Text.Json;
using FluentAssertions;
using Solutions.DayThirteen;
using Xunit;

namespace Tests.DayThirteen;

public class PartOneTests
{
	[Theory]
	[ClassData(typeof(PartOneTestsData))]
	public void PairIndicesSum(string input, int expected)
	{
		PartOne.PairIndicesSum(input).Should().Be(expected);
	}
}