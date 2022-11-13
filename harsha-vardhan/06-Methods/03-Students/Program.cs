using System;

class Student
{
  // receive all subjects as an array using 'params' modifier
  public void DisplaySubjects(params string[] subjects)
  {
    for (int i = 0; i < subjects.Length; i++) { Console.WriteLine(subjects[i]); }
  }

  public void DisplayMarks(int marks1, int marks2, int marks3)
  {
    Console.WriteLine("\nMarks 1: " + marks1);
    Console.WriteLine("Marks 2: " + marks2);
    Console.WriteLine("Marks 3: " + marks3);

    // using local function
    // Console.WriteLine("Average Marks: " + getAverageMarks()); 
    // static double getAverageMarks() { return (double)(marks1 + marks2 + marks3) / 3; }

    // using static local function
    Console.WriteLine("Average Marks: " + getAverageMarks(marks1, marks2, marks3));
    static double getAverageMarks(int m1, int m2, int m3) { return (double)(m1 + m2 + m3) / 3; }
  }

  public double Factorial(int number)
  {
    if (number == 0) return 1;
    else return number * Factorial(number - 1);
  }
}

class Program
{
  static void Main()
  {
    Student s = new Student();
    s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital System Design", "Basics of C");
    s.DisplayMarks(80, 45, 71);

    Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Factorial: ");
    Console.WriteLine("Enter a number: ");
    int n = int.Parse(Console.ReadLine());

    double fact = s.Factorial(n);
    Console.WriteLine("Factorial of " + n + " is " + fact);
    Console.ReadKey();
    Console.Clear();

    // n = 5
    // Factorial(5) = 5 * Factorial(4)
    // Factorial(4) = 4 * Factorial(3)
    // Factorial(3) = 3 * Factorial(2)
    // Factorial(2) = 2 * Factorial(1)
    // Factorial(1) = 1 * Factorial(0)
    // Factorial(0) = 1
  }
}