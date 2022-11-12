using System;

namespace _06_Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Product p1, p2;
      p1 = new Product();
      p2 = new Product();

      p1.cost = 1000;
      p2.cost = 30_000;

      p1.CalculateTax();
      p2.CalculateTax();

      Console.WriteLine("-------------------- p1 --------------------:");
      Console.WriteLine("cost: " + p1.cost);
      Console.WriteLine("CalculateTax: " + p1.tax);

      Console.WriteLine("\n-------------------- p2 --------------------:");
      Console.WriteLine("cost: " + p2.cost);
      Console.WriteLine("CalculateTax: " + p2.tax);
    }
  }
}
