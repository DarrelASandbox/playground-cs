/*
https://www.c-sharpcorner.com/article/ref-returns-in-c-sharp-7-0/

'ref returns' can be used to manipulate arrays or lists.

So instead of trying to access fields/properties of an object with 'ref return',
you can use it for general arbitrary data like arrays or lists or some collection.
*/

using System;

class Program
{
  static void Main(string[] args)
  {
    // Create an array of author names
    string[] authors = { "Mahesh Chand", "Mike Gold", "Dave McCarter", "Allen O'neill", "Raj Kumar" };
    // Call a method that returns by ref
    ref string author4 = ref new Program().FindAuthor(3, authors);
    // Prints 4th author in array = Allen O'neill
    Console.WriteLine("Original author: {0}", author4);
    // Replace 4th author by new author. By Ref, it will update the array
    author4 = "Chris Sells";
    // Print 4th author in array
    Console.WriteLine("Replaced author: {0}", authors[3]);
    // Prints Chris Sells
    Console.ReadKey();
    Console.Clear();
  }
  public ref string FindAuthor(int number, string[] names)
  {
    if (names.Length > 0)
      return ref names[number]; // return the storage location, not the value
    throw new IndexOutOfRangeException($"{nameof(number)} not found.");
  }
}