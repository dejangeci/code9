namespace _02_BadExamples
{
  using System.Collections.Generic;
  using System.Linq;

  public class Example08
  {
    const int CONDITION_PAYMENT = 50;

    List<int> SomeList = new List<int>();

    public Example08()
    {
      var t = new List<int>();
      for (int j = 0; j < 10; j++)
      {
        for (int y = 0; y < 10; y++)
        {
          t.Add(j * y);
        }
      }
    }

    public bool ClearItems()
    {
      List<int> tests = new List<int>();
      foreach (var c in SomeList)
      {
        bool boolean = c < CONDITION_PAYMENT;
        bool shouldClearAllItems = !boolean;
        if (shouldClearAllItems) tests.Add(c);
      }

      SomeList = tests.Select(counter => (int)counter).ToList();

      var conversionFailed = true;
      if (SomeList.Count != 0) conversionFailed = false;

      return conversionFailed;
    }
  }
}
