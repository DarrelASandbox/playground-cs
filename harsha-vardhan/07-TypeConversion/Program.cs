using System;

class TypeConversion
{
  public void ImplicitCasting()
  {
    short a = 100; // A variable of "lower numerical data tye" i.e. "short" (2 bytes)
    int b; // A variable of "higher numerical data tye" i.e. "int" (4 bytes)
    b = a; // short to int = lower to higher = implicit casting
    Console.WriteLine("Implicit Casting:");
    Console.WriteLine(a); // Output: 100
    Console.WriteLine(b); // Output: 100
  }

  public void ExplicitCasting()
  {
    int a = 100;
    short b;
    b = (short)a; // convert the value from "int" data type "short" data type (higher to lower), using "type casting" concept
    Console.WriteLine("\nExplicit Casting:");
    Console.WriteLine(a); // Output: 100
    Console.WriteLine(b); // Output: 100
    Console.ReadKey();
    Console.Clear();
  }

  public void Parse()
  {
    string s = "100";
    int x;
    x = int.Parse(s); // convert the value from "string" to "int" data type, using Parsing concept
    Console.WriteLine("Parse:");
    Console.WriteLine(s); // Output: 100
    Console.WriteLine(x); // Output: 100
  }

  public void TryParse()
  {
    string s = "1_234";
    int n;
    // try to convert "1_234" into "int" data type. If the conversion is successful, it returns the value into the "out" parameter & "true" directly.
    // If the conversion is unsuccessful, it returns "false".
    bool b = int.TryParse(s, out n);
    Console.WriteLine("\nTryParse:");
    Console.WriteLine(n); // Output: 0
    Console.WriteLine(b); // Output: False
    Console.ReadKey();
    Console.Clear();
  }

  public void Conversion()
  {
    double d = 100;
    int n;
    n = System.Convert.ToInt32(d); // convert the value from "double" data type to "int" data type", using conversion method
    Console.WriteLine("Conversion:");
    Console.WriteLine(d); // Output: 100
    Console.WriteLine(n); // Output: 100
    Console.ReadKey();
    Console.Clear();
  }
}

namespace _07_TypeConversion
{
  class Program
  {
    static void Main()
    {
      TypeConversion tc = new TypeConversion();
      tc.ImplicitCasting();
      tc.ExplicitCasting();
      tc.Parse();
      tc.TryParse();
      tc.Conversion();
    }
  }
}
