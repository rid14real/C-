using System;

namespace UsingOut
{
  class Program
  {
    static void Main(string[] args)
    {
      string word = "COULD YOU BE QUIET";
      bool silence;
      string result = Whisper(word, out silence);
      Console.WriteLine(result);
    }    
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
	}
}
