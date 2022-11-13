using System;

class Student
{
  // receive all subjects as an array using 'params' modifier
  public void DisplaySubjects(params string[] subjects)
  {
    for (int i = 0; i < subjects.Length; i++)
    {
      System.Console.WriteLine(subjects[i]);
    }
  }
}

class Program
{
  static void Main()
  {
    Student s = new Student();
    s.DisplaySubjects("Theory of Computation", "Computer Networks", "Discrete Mathematics", "Digital System Design", "Basics of C");
    Console.ReadKey();
    Console.Clear();
  }
}