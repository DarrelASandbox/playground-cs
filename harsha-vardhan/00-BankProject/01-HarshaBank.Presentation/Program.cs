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
            case 1: CustomersMenu(); break;
            case 2: AccountsMenu(); break;
            case 3: FundsTransferMenu(); break;
            case 4: FundsTransferStatementMenu(); break;
            case 5: AccountStatementMenu(); break;
          }
        } while (mainMenuChoice != 0);
      }
      else Console.WriteLine("Incorrect credentials");

      Console.WriteLine("Thank you for banking with us!");
      Console.ReadKey();
      Console.Clear();
    }
    static void CustomersMenu()
    {
      int customerMenuChoice = -1;

      do
      {
        Console.WriteLine("\n:::Customers Menu:::");
        Console.WriteLine("1. Add Customer");
        Console.WriteLine("2. Delete Customer");
        Console.WriteLine("3. Update Customer");
        Console.WriteLine("4. View Customers");
        Console.WriteLine("0. Back to Main Menu");

        Console.WriteLine("Enter choice:");
        customerMenuChoice = Convert.ToInt32(Console.ReadLine());
      } while (customerMenuChoice != 0);
    }
    static void AccountsMenu()
    {
      int accountMenuChoice = -1;

      do
      {
        Console.WriteLine("\n:::Accounts Menu:::");
        Console.WriteLine("1. Add Account");
        Console.WriteLine("2. Delete Account");
        Console.WriteLine("3. Update Account");
        Console.WriteLine("4. View Accounts");
        Console.WriteLine("0. Back to Main Menu");

        Console.WriteLine("Enter choice:");
        accountMenuChoice = Convert.ToInt32(Console.ReadLine());
      } while (accountMenuChoice != 0);
    }
    static void FundsTransferMenu() { }
    static void FundsTransferStatementMenu() { }
    static void AccountStatementMenu() { }
  }
}
