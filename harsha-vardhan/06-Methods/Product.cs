public class Product
{
  public double cost;
  public double tax;

  public void CalculateTax()
  {
    double t;

    if (cost <= 20000) t = cost * 10 / 100;
    else t = cost * 12.5 / 100;

    tax = t;
  }
}

