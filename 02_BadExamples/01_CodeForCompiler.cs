namespace _02_BadExamples
{
  using System;
  using System.Collections.Generic;

  public static class Example01
  {
    static void CodeWrittenForCompiler()
    {
      var l=new List<int>();for(int i=0;i<200;i++)if(i%3==0||i%5==0)l.Add(i*i);foreach(var n in l)Console.Write(n);
    }

    static void CodeWrittenForHumans()
    {
      var listOfSquares = new List<int>();
      for (int i = 0; i < 200; i++)
      {
        var isDivisibleBy3or5 = (i % 3) == 0 || (i % 5) == 0;
        if (isDivisibleBy3or5)
        {
          listOfSquares.Add(i * i);
        }
      }

      foreach (var number in listOfSquares)
      {
        Console.Write(number);
      }
    }
  }
}
