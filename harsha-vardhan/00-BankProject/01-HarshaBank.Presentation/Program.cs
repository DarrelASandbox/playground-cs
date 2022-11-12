using System;

namespace _01_HarshaBank.Presentation
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("*************** Harsha Bank ***************");
      Console.WriteLine("::Login Page::");

      string userName = null, password = null;

      Console.Write("Username:");
      userName = Console.ReadLine();

      if (userName != "")
      {
        Console.Write("Password:");
        password = Console.ReadLine();
      }

      if (userName == "system" && password == "manager")
      {
        int mainMenuChoice = -1;

        do
        {
          Console.WriteLine("\n:::Main Menu:::");
          Console.WriteLine("1: Customers");
          Console.WriteLine("2: Accounts");
          Console.WriteLine("3: Funds Transfer");
          Console.WriteLine("4: Funds Transfer Statement");
          Console.WriteLine("5: Account Statement");
          Console.WriteLine("0. Exit");

          Console.Write("Enter choice:");
          mainMenuChoice = int.Parse(Console.ReadLine());

          switch (mainMenuChoice)
          {
            case 1: // @TODO: Display Customers Menu
              break;
            case 2: // @TODO: Display Accounts Menu
              break;
            case 3: // @TODO: Display Funds Transfer Menu
              break;
            case 4: // @TODO: Display Funds Transfer Statement Menu
              break;
            case 5: // @TODO: Display Account Statement Menu
              break;
          }
        } while (mainMenuChoice != 0);
      }
      else Console.WriteLine("Incorrect credentials");

      Console.WriteLine("Thank you for banking with us!");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
