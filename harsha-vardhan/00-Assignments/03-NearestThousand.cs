/*
Write a C# program to get nearest thousand of given integer number.
Here, let name the input value as "number".

If the number's last three digits are greater than or equal to 500; it should "round up" the number.
If the number's last three digits are less than 500; it should "round down" the number.
If the number is less than 500; it should round up to 1000.

Eg:
Input: 499  Output: 1000
Input: 500  Output: 1000
Input: 999  Output: 1000
Input: 1000 Output: 1000
Input: 1499 Output: 1000
Input: 1500 Output: 2000

Note: Don't use any predefined math functions.
*/

using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void NearestThousand()
    {
      int number = 3852;

      // upcasting (converting) the 'int' input value to 'decimal' type
      // so that, we can get fractional value while dividing the number below
      decimal decimal_number = number;

      // Round down to previous thousand. Means, replace the last three digits with '000'. 
      // 'number / 1000' will integer divide (because the 'number' variable is an 'int') with 1000. 
      // So you will get '3' in this example. Then multiply the same with 1000. So it becomes '3000'
      int previous_thousand = number / 1000 * 1000;
      decimal last_three_digits_x = decimal_number / 1000;
      decimal last_three_digits_y = number / 1000;

      // Then we will subtract these 'x' and 'y'. So "3.852 - 3" will be "0.852".
      // Then we will multiply the same with 1000. So "0.852 * 1000" will be "852".
      // In this way, we are getting the last three digits of the actual number.
      decimal last_three_digits = (last_three_digits_x - last_three_digits_y) * 1000;
      int rounding_value = (last_three_digits >= 500) ? 1000 : 0;
      int is_less_than_five_hundred = (number < 500) ? 1000 : 0;
      int nearest_thousand = previous_thousand + rounding_value + is_less_than_five_hundred;

      Console.WriteLine("NearestThousand: " + nearest_thousand);
    }
  }
}
