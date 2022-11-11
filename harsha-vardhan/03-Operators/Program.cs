using System;

namespace _03_Operators
{
  class Program
  {
    static void Main(string[] args)
    {
      double a = 10, b = 3;
      // addition
      double c = a + b;
      // subtraction
      double d = a - b;
      // multiplication
      double e = a * b;
      // division
      double f = a / b;
      // remainder
      double g = a % b;
      // display all the values
      Console.WriteLine("a: " + a); // Output: 10
      Console.WriteLine("b: " + b); // Output: 3
      Console.WriteLine("c = a + b: " + c); // Output: 13
      Console.WriteLine("d = a - b: " + d); // Output: 7
      Console.WriteLine("e = a * b: " + e); // Output: 30
      Console.WriteLine("f = a / b: " + f); // Output: 3.3333333333
      Console.WriteLine("g = a % b: " + g); // Output: 1
      Console.ReadKey();
      Console.Clear();

      int n = 10;
      // display the value of "n"
      Console.WriteLine("n: " + n);   // Output: 10
                                      // n = n + 1
      n++;
      Console.WriteLine("n++: " + n);   // Output: 11
                                        // n = n - 1
      n--;
      Console.WriteLine("n--: " + n);   // Output: 10
      Console.ReadKey();
      Console.Clear();

      // create two variables of "long" data type
      long x = 1000, y = 2000;
      // check whether x and y are equal
      bool b1 = (x == y);
      // check whether x and y are not equal
      bool b2 = (x != y);
      // check whether x is less than y
      bool b3 = (x < y);
      // check whether x is greater than y
      bool b4 = (x > y);
      // check whether x is less than or equal to y
      bool b5 = (x <= y);
      // check whether x is greater than or equal to y
      bool b6 = (x >= y);
      Console.WriteLine("x: " + x + " y:" + y);
      Console.WriteLine("x == y: " + b1); // Output: false
      Console.WriteLine("x != y: " + b2); // Output: true
      Console.WriteLine("x < y: " + b3); // Output: true
      Console.WriteLine("x > y: " + b4); // Output: false
      Console.WriteLine("x <= y: " + b5); // Output: true
      Console.WriteLine("x >= y: " + b6); // Output: false
      Console.ReadKey();
      Console.Clear();

      int az = 10, bz = 20, cz = 10;
      Console.WriteLine("az: " + az + " bz: " + bz + " cz: " + cz);

      // and
      bool result1 = ((az == bz) && (bz > cz));
      Console.WriteLine("((az == bz) && (bz > cz)): " + result1); // Output: false
                                                                  // or
      bool result2 = ((az == bz) || (bz > cz));
      Console.WriteLine("((az == bz) || (bz > cz)): " + result2); // Output: true
                                                                  // not
      bool result3 = !(az == bz);
      Console.WriteLine("!(az == bz): " + result3); // Output: true
      Console.ReadKey();
      Console.Clear();
    }
  }
}
