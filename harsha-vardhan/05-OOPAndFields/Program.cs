﻿using System;

class Program
{
  static void Main()
  {
    // create reference variables
    Product p1, p2, p3;

    // create objects
    p1 = new Product();
    p2 = new Product();
    p3 = new Product();

    // initialize fields
    p1.productID = 1001;
    p1.productName = "Mobile";
    p1.cost = 1200;
    p1.quantityInStock = 4500;

    p2.productID = 1002;
    p2.productName = "Laptop";
    p2.cost = 3200;
    p2.quantityInStock = 400;

    p3.productID = 1003;
    p3.productName = "Speakers";
    p3.cost = 400;
    p3.quantityInStock = 800;

    Console.WriteLine("---------- p1 ----------:");
    Console.WriteLine("productID: " + p1.productID);
    Console.WriteLine("productName: " + p1.productName);
    Console.WriteLine("cost: " + p1.cost);
    Console.WriteLine("quantityInStock: " + p1.quantityInStock);

    Console.WriteLine("\n---------- p2 ----------:");
    Console.WriteLine("productID: " + p2.productID);
    Console.WriteLine("productName: " + p2.productName);
    Console.WriteLine("cost: " + p2.cost);
    Console.WriteLine("quantityInStock: " + p2.quantityInStock);

    Console.WriteLine("\n---------- p3 ----------:");
    Console.WriteLine("productID: " + p3.productID);
    Console.WriteLine("productName: " + p3.productName);
    Console.WriteLine("cost: " + p3.cost);
    Console.WriteLine("quantityInStock: " + p3.quantityInStock);
  }
}