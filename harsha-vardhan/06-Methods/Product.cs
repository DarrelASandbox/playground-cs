public class Product
{
  private int productID;
  private double cost;
  private double tax;
  private int quantityInStock;
  public static int TotalNoProducts;

  public void CalculateTax()
  {
    double t;

    if (cost <= 20000) t = cost * 10 / 100;
    else t = cost * 12.5 / 100;

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
}

