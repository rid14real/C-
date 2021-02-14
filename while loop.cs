using System;

namespace WhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      int emails = 20;  
      while (emails > 0)
      {
        emails--;
        Console.WriteLine($"I'm presently deleting emails, {emails} emails remaining.");
      }
      Console.WriteLine("INBOX ZERO ACHIEVED!");
    }
  }
}
