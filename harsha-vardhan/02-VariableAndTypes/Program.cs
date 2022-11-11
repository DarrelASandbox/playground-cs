using System;

namespace _02_VariableAndTypes
{
  class Program
  {
    static void Main(string[] args)
    {
      //create variables for all numerical data types
      sbyte a = 10;
      byte b = 20;
      short c = 30;
      ushort d = 40;
      int e = 50;
      uint f = 60;
      long g = 70;
      ulong h = 80;
      float i = 90.23F;
      double j = 100.23489;
      decimal k = 110.882932M;
      char ch = 'A';
      string s = "Hello 123 $#&";
      bool boo = true;

      Console.WriteLine("sbyte:\t " + a);
      Console.WriteLine("byte:\t " + b);
      Console.WriteLine("short:\t " + c);
      Console.WriteLine("ushort:\t " + d);
      Console.WriteLine("int:\t " + e);
      Console.WriteLine("uint:\t " + f);
      Console.WriteLine("long:\t " + g);
      Console.WriteLine("ulong:\t " + h);
      Console.WriteLine("float:\t " + i);
      Console.WriteLine("double:\t " + j);
      Console.WriteLine("decimal: " + k);
      Console.WriteLine("char: " + ch);
      Console.WriteLine("string: " + s);
      Console.WriteLine("bool: " + boo);
      Console.ReadKey();
      Console.Clear();

      //get the minimum value of "int" data type
      int min = int.MinValue;
      //get the maximum value of "int" data type
      int max = int.MaxValue;
      //display the min and max values
      Console.WriteLine("int min: " + min);
      Console.WriteLine("int max:  " + max);
      Console.ReadKey();
      Console.Clear();
    }
  }
}
