using System;

namespace JumpStatements
{
  class Program
  {
    static void Main(string[] args)
    {
      bool buttonClick = false;

      int stop = 0;
      do
      {
        Console.WriteLine("BLARRRRR");
        counter++;

        if (counter == 3)
          {
            break;
          }
      } while(!buttonClick);
    }
  }
}