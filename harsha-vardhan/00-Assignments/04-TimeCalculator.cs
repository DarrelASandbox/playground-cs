/*
Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
Eg:
seconds = 288970
The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"
Output: 3 days, 8 hours, 16 minutes, 10 seconds
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void TimeCalculator()
    {
      int seconds = 288970;

      int remaining_seconds = seconds;
      int seconds_per_minute = 60;
      int seconds_per_hour = 60 * 60;
      int seconds_per_day = 24 * 60 * 60;

      int days = remaining_seconds / seconds_per_day;
      remaining_seconds -= days * seconds_per_day;

      int hours = remaining_seconds / seconds_per_hour;
      remaining_seconds -= hours * seconds_per_hour;
      int minutes = remaining_seconds / seconds_per_minute;
      remaining_seconds -= minutes * seconds_per_minute;

      Console.WriteLine("TimeCalculator: " + days + " days, " + hours + " hours, " + minutes + " minutes, " + remaining_seconds + " seconds");
    }
  }
}

