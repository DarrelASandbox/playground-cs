using System;

// fields
public class Product
{
  public int productID;
  public string productName;
  public double cost;
  public int quantityInStock;

  public static int TotalNoProducts;
  public const string CategoryName = "Electronics";
  public readonly string dateOfPurchase;

  // constructor
  public Product()
  {
    dateOfPurchase = DateTime.Now.ToLongDateString();
  }
}

