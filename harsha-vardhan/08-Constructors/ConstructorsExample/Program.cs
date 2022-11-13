using System;

class Program
{
  static void Main()
  {
    Employee emp0 = new Employee();
    Employee emp1 = new Employee(101, "Scott", "Manager");
    Employee emp2 = new Employee(102, "Allen", "Asst. Manager");
    Employee emp3 = new Employee(103, "Anna", "Clerk");
    Employee emp4 = new Employee() { empName = "Ford", job = "Executive" }; // Object Initializer

    Console.WriteLine("----- " + Employee.companyName + " -----");
    Console.WriteLine("\nZeroth employee:");
    Console.WriteLine(emp0.empID);
    Console.WriteLine(emp0.empName);
    Console.WriteLine(emp0.job);

    Console.WriteLine("\nFirst employee:");
    Console.WriteLine(emp1.empID);
    Console.WriteLine(emp1.empName);
    Console.WriteLine(emp1.job);

    Console.WriteLine("\nSecond employee:");
    Console.WriteLine(emp2.empID);
    Console.WriteLine(emp2.empName);
    Console.WriteLine(emp2.job);

    Console.WriteLine("\nThird employee:");
    Console.WriteLine(emp3.empID);
    Console.WriteLine(emp3.empName);
    Console.WriteLine(emp3.job);

    Console.WriteLine("\nFourth employee:");
    Console.WriteLine(emp4.empID);
    Console.WriteLine(emp4.empName);
    Console.WriteLine(emp4.job);

    Console.ReadKey();
    Console.Clear();
  }
}