using System;

namespace _06_Methods
{
  class Program
  {
    static void Main(string[] args)
    {
      Product p1, p2, p3, p4, p5, p6, p7;
      p1 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p2 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p3 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p4 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p5 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p6 = new Product();
      Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);
      p7 = new Product();
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
      p3.CalculateTax(50000, 27); // method overloading
      p3.SetQuantityInStock(4000);

      double percentage1 = 1;
      p4.SetProductID(1004);
      p4.SetCost(50_000);
      p4.CalculateTaxPMDefault(percentage: percentage1); // default parameter modifier
      p4.SetQuantityInStock(4000);

      double percentage2 = 2;
      p5.SetProductID(1005);
      p5.SetCost(50_000);
      p5.CalculateTaxPMRef(percentage: ref percentage2); // ref parameter modifier
      p5.SetQuantityInStock(4000);

      p6.SetProductID(1006);
      p6.SetCost(50_000);
      p6.CalculateTaxPMOut(percentage: out double percentage3); // out parameter modifier
      p6.SetQuantityInStock(4000);

      double percentage4 = 4;
      p7.SetProductID(1007);
      p7.SetCost(50_000);
      p7.CalculateTaxPMIn(percentage: in percentage4); // in parameter modifier
      p7.SetQuantityInStock(4000);

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

      Console.WriteLine("\n-------------------- p4 --------------------:");
      Console.WriteLine("productID: " + p4.GetProductID());
      Console.WriteLine("cost: " + p4.GetCost());
      Console.WriteLine("CalculateTaxPMDefault: " + p4.GetTax());
      Console.WriteLine("Unchanged @ 1% - percentage1: " + percentage1 + "%");

      Console.WriteLine("\n-------------------- p5 --------------------:");
      Console.WriteLine("productID: " + p5.GetProductID());
      Console.WriteLine("cost: " + p5.GetCost());
      Console.WriteLine("CalculateTaxPMRef: " + p5.GetTax());
      Console.WriteLine("Changed from 2% to 5% - percentage2: " + percentage2 + "%");

      Console.WriteLine("\n-------------------- p6 --------------------:");
      Console.WriteLine("productID: " + p6.GetProductID());
      Console.WriteLine("cost: " + p6.GetCost());
      Console.WriteLine("CalculateTaxPMOut: " + p6.GetTax());
      Console.WriteLine("Value taken from CalculateTaxPMOut() in Product.cs - percentage3: " + percentage3 + "%");

      Console.WriteLine("\n-------------------- p7 --------------------:");
      Console.WriteLine("productID: " + p7.GetProductID());
      Console.WriteLine("cost: " + p7.GetCost());
      Console.WriteLine("CalculateTaxPMIn: " + p7.GetTax());
      Console.WriteLine("Value taken from CalculateTaxPMOut() in Program.cs - percentage4: " + percentage4 + "%");

      Console.WriteLine("\n--------------------------------------------:");
      Console.WriteLine("Total quantityInStock: " + Product.GetTotalQuantity(p1, p2));
      Console.WriteLine("TotalNoProducts: " + Product.GetTotalNoOfProducts());
    }
  }
}
