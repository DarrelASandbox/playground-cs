/*
You have the following values to convert:

byte a = 10; // Convert this value into "short" type (assign into another short type of variable)
int b = 10; // Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; // Convert this value into "double" type using Parse  // Also, convert the same value into "decimal" type  using TryParse
decimal d; // Convert this value into "string" type (assign into another string type of variable)
And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.


You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.
1. Implicit Casting
2. Explicit Casting
3. Parse or TryParse (as suggested above)
4. Conversion Methods
*/
using System;

namespace _00_Assignments
{
  public partial class AssignmentsClass
  {
    public void TypeConversion()
    {
      byte a = 10; // byte type
      short e = a; // byte to short
      Console.WriteLine("Implicit Casting: " + e);

      int b = 10; // int type
      short f = (short)b; // int to short
      Console.WriteLine("Explicit Casting: " + f);

      string c = "10.34"; // string type
      double g = double.Parse(c); // string to double
      Console.WriteLine("Parse: " + g);

      bool isConverted = decimal.TryParse(c, out decimal h); // string to decimal
      if (isConverted)
        Console.WriteLine("TryParse: " + h);
      else
        Console.WriteLine("TryParse did not convert");

      decimal d = 11.56M; // decimal type
      string i = Convert.ToString("Conversion Methods: " + d); // decimal to string
      Console.WriteLine(i);
    }
  }
}

