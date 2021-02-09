using System;

namespace OutParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;
      bool outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);

      int nameAsInt;
      bool outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
      Console.WriteLine(outcome2);
    }    

	}
}