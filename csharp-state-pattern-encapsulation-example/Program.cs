namespace CSharpStatePatternEncapsulationExample
{
  using CSharpStatePatternEncapsulationExample.States;
  using System;

  class Program
  {
    static void Main(string[] args)
    {
      var context = new Context(new DuckState(), Season.Duck);

      for (int i = 0; i < 5; i++)
      {
        context.Request();
        Console.WriteLine("Current season: {0} season", context.CurrentSeason.ToString());
      }

      Console.ReadKey(true);
    }
  }
}
