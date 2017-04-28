namespace _01_CSharpGuidelines
{
  using System.Collections.Generic;

  public class ForAndForeach
  {
    private List<int> numberList = new List<int>();

    public int MethodWithFor1()
    {
      int sum = 0;
      for (int i = 0; i < numberList.Count; i++)
      {
        sum += numberList[i];
      }

      return sum;
    }

    public int MethodWithFor2()
    {
      int sum = 0;
      for (int i = 0; i < numberList.Count; i++) sum += numberList[i];

      return sum;
    }

    public int MethodWithForeach1()
    {
      int sum = 0;
      foreach (var number in numberList)
      {
        sum += number;
      }

      return sum;
    }

    public int MethodWithForeach2()
    {
      int sum = 0;
      foreach (var number in numberList) sum += number;

      return sum;
    }
  }
}
