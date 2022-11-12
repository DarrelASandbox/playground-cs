/*
Write a C# program to calculate "area of circle" based on the given "radius" value.
The radius value can be assigned to a variable; need not to take the value from the keyboard input.

Formula: PI * radius * radius

PI is a constant value, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter. 
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void AreaOfCircle()
    {
      double pi = 3.14159;  // a constant value
      int radius = 5;
      double area = pi * radius * radius;

      Console.WriteLine("AreaOfCircle: " + area);
    }
  }
}
