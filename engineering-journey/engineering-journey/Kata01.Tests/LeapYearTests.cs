using System;
using Xunit;

namespace Kata01.Tests;

public class LeapYearTests
{
    [Theory]
    [InlineData(2000, true)]  // 400'e bölünür
    [InlineData(1900, false)] // 100'e bölünür ama 400'e bölünmez
    [InlineData(2024, true)]  // 4'e bölünür, 100'e bölünmez
    [InlineData(2023, false)] // 4'e bölünmez
    public void IsLeapYear_ReturnsExpected(int year, bool expected)
    {
        var result = LeapYear.IsLeapYear(year);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(10000)]
    public void IsLeapYear_Throws_ForOutOfRangeYears(int year)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => LeapYear.IsLeapYear(year));
    }
}
