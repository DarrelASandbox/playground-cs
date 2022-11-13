﻿public class Product
{
  public int productID;
  public double cost;
  public double tax;

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

}

