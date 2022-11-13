using System;

namespace _06_Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Product p1, p2, p3;
      p1 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p2 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p3 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);

      p1.SetProductID(1001);
      p1.SetCost(1000);
      p1.CalculateTax(percentage: 15); // pass in named argument `percentage`
      p1.SetQuantityInStock(4500);

      p2.SetProductID(1002);
      p2.SetCost(30_000);
      p2.CalculateTax(); // using default arguments
      p2.SetQuantityInStock(400);

      p3.SetProductID(1003);
      p3.SetCost(50_000);
      p3.CalculateTax(10000, 27); // method overloading
      p3.SetQuantityInStock(4000);

      Console.WriteLine("-------------------- p1 --------------------:");
      Console.WriteLine("productID: " + p1.GetProductID());
      Console.WriteLine("cost: " + p1.GetCost());
      Console.WriteLine("CalculateTax: " + p1.GetTax());

      Console.WriteLine("\n-------------------- p2 --------------------:");
      Console.WriteLine("productID: " + p2.GetProductID());
      Console.WriteLine("cost: " + p2.GetCost());
      Console.WriteLine("CalculateTax: " + p2.GetTax());

      Console.WriteLine("\n-------------------- p3 --------------------:");
      Console.WriteLine("productID: " + p3.GetProductID());
      Console.WriteLine("cost: " + p3.GetCost());
      Console.WriteLine("CalculateTax: " + p3.GetTax());

      Console.WriteLine("\n--------------------------------------------:");
      Console.WriteLine("Total quantityInStock: " + Product.GetTotalQuantity(p1, p2));
      Console.WriteLine("TotalNoProducts: " + Product.GetTotalNoOfProducts());
    }
  }
}
