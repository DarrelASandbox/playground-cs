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

      p1.SetProductID(1001);
      p1.SetCost(1000);
      p2.SetProductID(1002);
      p2.SetCost(30_000);

      p1.CalculateTax();
      p2.CalculateTax();

      Console.WriteLine("-------------------- p1 --------------------:");
      Console.WriteLine("productID: " + p1.GetProductID());
      Console.WriteLine("cost: " + p1.GetCost());
      Console.WriteLine("CalculateTax: " + p1.GetTax());

      Console.WriteLine("\n-------------------- p2 --------------------:");
      Console.WriteLine("productID: " + p2.GetProductID());
      Console.WriteLine("cost: " + p2.GetCost());
      Console.WriteLine("CalculateTax: " + p2.GetTax());
    }
  }
}
