namespace _02_BadExamples
{
  using System.Collections.Generic;
  using System.Linq;

  public static class Example05
  {
    public static List<int> Triangle(int n)
    {
      int[][] triangle = new int[n][];

      for (int i = 0; i < n; i++)
      {
        triangle[i] = new int[i + 1];
        triangle[i][0] = triangle[i][i] = 1;

        if (i < 2) continue;

        for (int j = 0; j < i - 1; j++)
          triangle[i][j + 1] = triangle[i - 1][j] + triangle[i - 1][j + 1];
      }

      return triangle.SelectMany(item => item).ToList();
    }
  }
}
