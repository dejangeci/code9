namespace _02_BadExamples
{
  using System;
  using System.Linq;

  public class Example03
  {
    public int HammingWeight_Complicated(int x)
    {
      byte[] four_b = new byte[32];
      if (x < 0) four_b[0] = 1;
      x = Math.Abs(x);
      int i = four_b.Length - 1;
      while (x > 0) //Sign and magnitude method
      {
        four_b[i--] = (byte)(x % 2);
        x /= 2;
      }
      if (four_b[0] == 1)
      {
        for (i = 1; i < four_b.Length; i++) //Ones complement
        {
          four_b[i] = (byte)((four_b[i] + 1) % 2);
        }
        i = four_b.Length - 1;
        do
        { //Twos complement
          four_b[i] = (byte)((four_b[i--] + 1) % 2);
        } while (four_b[i + 1] == 0);
      }
      return four_b.Count(n => n == 1);
    }

    public int HammingWeight_Simple(int x)
    {
      int count = 0;
      foreach (var b in BitConverter.GetBytes(x))
        for (int i = 1; i <= 8; i++)
          if ((b & (1 << i - 1)) != 0) count++;

      return count;
    }
  }
}
