/*
Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
Height categories:
Height is less than 150 cm = "Dwarf"
Height is between 150 cm and 165 cm = "Average height"
Height is between 165 cm and 195 cm = "Tall"
Height is above 195 cm = "Abnormal height"

Note: 1 inch = 2.54 centimeter

Eg:
Input: 75
Output: Tall
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void HeightCategory()
    {
      int height_in_inches = 75;
      double height_in_cm = height_in_inches * 2.54;  // 1 inch = 2.54 centimeter
      string result = null;

      if (height_in_cm < 150)
        result = "Dwarf";
      else if (height_in_cm >= 150 && height_in_cm <= 165)
        result = "Average height";
      else if (height_in_cm > 165 && height_in_cm <= 195)
        result = "Tall";
      else
        result = "Abnormal height";

      Console.WriteLine("HeightCategory: " + result);
    }
  }
}
