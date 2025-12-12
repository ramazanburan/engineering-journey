using System;

namespace Kata01;

public static class LeapYear
{
    public static bool IsLeapYear(int year)
    {
        // Guard clause: veri bütünlüğü
        if (year is < 1 or > 9999)
            throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1 and 9999.");

        // Kurallar: 400 > 100 > 4 öncelik sırasıyla ele alınır
        if (year % 400 == 0) return true;
        if (year % 100 == 0) return false;
        return year % 4 == 0;
    }
}
