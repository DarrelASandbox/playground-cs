public class Product
{
  private int productID;
  private double cost;
  private double tax;
  private int quantityInStock;
  public static int TotalNoProducts;

  public void CalculateTax(double percentage = 12.5)
  {
    double t;
    if (cost <= 20000) t = cost * 10 / 100;
    else t = cost * percentage / 100;
    tax = t;
  }

  public void CalculateTax(double cost, double percentage)
  {
    double t;
    if (cost <= 30000) t = cost * 20 / 100;
    else t = cost * percentage / 100;
    System.Console.WriteLine("t" + t);
    tax = t;
  }

  // For Parameter Modifiers
  public void CalculateTaxPMDefault(double percentage)
  {
    percentage = 5;
    double t;
    if (cost <= 30000) t = cost * 20 / 100;
    else t = cost * percentage / 100;
    tax = t;
  }

  public void CalculateTaxPMRef(ref double percentage)
  {
    percentage = 5;
    double t;
    if (cost <= 30000) t = cost * 20 / 100;
    else t = cost * percentage / 100;
    tax = t;
  }

  public void CalculateTaxPMOut(out double percentage)
  {
    percentage = 3;
    double t;
    if (cost <= 30000) t = cost * 20 / 100;
    else t = cost * percentage / 100;
    tax = t;
  }

  public void CalculateTaxPMIn(in double percentage)
  {
    double t;
    if (cost <= 30000) t = cost * 20 / 100;
    else t = cost * percentage / 100;
    tax = t;
  }

  public void SetProductID(int value) { productID = value; }
  public int GetProductID() { return productID; }
  public void SetCost(double value) { cost = value; }
  public double GetCost() { return cost; }
  public void SetTax(double value) { tax = value; }
  public double GetTax() { return tax; }
  public int GetQuantityInStock() { return quantityInStock; }
  public void SetQuantityInStock(int value) { quantityInStock = value; }
  public static void SetTotalNoOfProducts(int value) { TotalNoProducts = value; }
  public static int GetTotalNoOfProducts() { return TotalNoProducts; }
  public static int GetTotalQuantity(Product p1, Product p2) { return p1.GetQuantityInStock() + p2.GetQuantityInStock(); }

  public void DisplayProducts(params string[] products)
  {
    for (int i = 0; i < products.Length; i++) { System.Console.WriteLine(products[i]); }
  }
}

