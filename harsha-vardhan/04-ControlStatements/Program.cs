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

      int monthNumber = 7;
      string monthName;

      Console.WriteLine("monthNumber = " + 7);

      // check the value of monthNumber whether it matches with any one of the following cases
      switch (monthNumber)
      {
        case 1: monthName = "Jan"; break;
        case 2: monthName = "Feb"; break;
        case 3: monthName = "Mar"; break;
        case 4: monthName = "Apr"; break;
        case 5: monthName = "May"; break;
        case 6: monthName = "Jun"; break;
        case 7: monthName = "Jul"; break;
        case 8: monthName = "Aug"; break;
        case 9: monthName = "Sep"; break;
        case 10: monthName = "Oct"; break;
        case 11: monthName = "Nov"; break;
        case 12: monthName = "Dec"; break;
        default: monthName = "unknown"; break;
      }
      Console.WriteLine("monthName: " + monthName); // Output: Jul
      Console.ReadKey();
      Console.Clear();


      int i = 1;
      Console.WriteLine("while loop:");
      while (i <= 10)
      {
        Console.WriteLine(i);
        i++;
      }
      Console.ReadKey();
      Console.Clear();

      do
      {
        Console.WriteLine("do while:");
        Console.WriteLine("i: " + i);
        i++;
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

      System.Console.WriteLine("skip \"6\" and go to \"7\":");
      for (int k = 1; k <= 10; k++)
      {
        if (k == 6)
          continue;
        System.Console.WriteLine(k);
      }
      System.Console.ReadKey();
      Console.Clear();

      System.Console.WriteLine("goto myLabel:");
      Console.WriteLine("one");
      Console.WriteLine("two");

      // jump to myLabel
      goto myLabel;
      Console.WriteLine("three");
      Console.WriteLine("four");
      Console.WriteLine("five");

    // myLabel starts here
    myLabel:
      Console.WriteLine("six");
      Console.WriteLine("seven");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
