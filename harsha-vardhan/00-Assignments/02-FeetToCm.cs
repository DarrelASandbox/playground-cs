/*
Write a C# program convert a person's height (in feet and inches) to centimeters.
Eg:
feet = 5
inches = 7
output: 170.18 cm

Formula:
1 inch = 2.54 cm
1 feet = 12 inches
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void FeetToCm()
    {
      int feet = 5, inches = 7;
      int total_inches = (feet * 12) + inches;
      double centimeters = total_inches * 2.54;

      Console.WriteLine("FeetToCm: " + centimeters);
    }
  }
}
