// Class that represents an employee in the organization
public class Employee
{
  public uint EmployeeID;
  public string EmployeeName;
  public double SalaryPerHour;
  public double NoOfWorkingHours;
  public double NetSalary;

  public static string OrganizationName;
  public const string TypeOfEmployee = "Contract Based";
  public readonly string DepartmentName;

  // constructor: executes every time when we create an object for the Employee class.
  public Employee()
  {
    //initialize readonly field
    DepartmentName = "Finance Department";
  }
}

