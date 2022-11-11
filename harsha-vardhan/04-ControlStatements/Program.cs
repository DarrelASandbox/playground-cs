using System;

namespace _04_ControlStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      int az1 = 10, bz1 = 20;

      Console.WriteLine("az1: " + az1 + " bz1: " + bz1);
      // check which is the big number
      if (az1 == bz1)
        Console.WriteLine("az1 and bz1 are equal");
      else if (az1 > bz1)
        Console.WriteLine("az1 is bigger than bz1");
      else
        Console.WriteLine("bz1 is bigger than az1");

      Console.ReadKey();
      Console.Clear();

      int monthnumber = 7;
      string monthname;

      Console.WriteLine("monthnumber = " + 7);

      // check the value of monthnumber whether it matches with any one of the following cases
      switch (monthnumber)
      {
        case 1: monthname = "Jan"; break;
        case 2: monthname = "Feb"; break;
        case 3: monthname = "Mar"; break;
        case 4: monthname = "Apr"; break;
        case 5: monthname = "May"; break;
        case 6: monthname = "Jun"; break;
        case 7: monthname = "Jul"; break;
        case 8: monthname = "Aug"; break;
        case 9: monthname = "Sep"; break;
        case 10: monthname = "Oct"; break;
        case 11: monthname = "Nov"; break;
        case 12: monthname = "Dec"; break;
        default: monthname = "unknown"; break;
      }
      Console.WriteLine("monthname: " + monthname); // Output: Jul
      Console.ReadKey();
      Console.Clear();


      int i = 1;
      Console.WriteLine("while loop:");
      while (i <= 10)
      {
        Console.WriteLine(i);
        i++; // incrementation
      }
      Console.ReadKey();
      Console.Clear();

      do
      {
        Console.WriteLine("do while:");
        Console.WriteLine("i: " + i);
        i++; // incrementation
      } while (i <= 10);
      Console.ReadKey();
      Console.Clear();

      Console.WriteLine("for loop:");
      for (int j = 1; j <= 10; j++)
      {
        Console.WriteLine(j);
      }
      Console.ReadKey();
      Console.Clear();

      Console.WriteLine("one");
      Console.WriteLine("two");

      // jump to mylabel
      goto mylabel;
      Console.WriteLine("three");
      Console.WriteLine("four");
      Console.WriteLine("five");

    // mylabel starts here
    mylabel:
      Console.WriteLine("six");
      Console.WriteLine("seven");
      Console.ReadKey();
    }
  }
}
