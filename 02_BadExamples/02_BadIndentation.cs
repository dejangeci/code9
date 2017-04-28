using System.Text.RegularExpressions;
        namespace _02_BadExamples
 {
using System;

  public class Example02
  {
    public int? ToSeconds(string time)
      {
      var match = Regex.Match(time, "^([0-9]{2}):([0-9]{2}):([0-9]{2})$");

if (!match.Success) return null;

      var h = int.Parse(match.Groups[1].Value);
       var m = int.Parse(match.Groups[2].Value);
        var s = int.Parse(match.Groups[3].Value);

 if (m > 59 || s > 59)
{ return null; }

      return h * 60 * 60 + m * 60 + s;
}

public int HammingWeight(int x)
{
int count = 0;
foreach (var b in BitConverter.GetBytes(x))
for (int i = 1; i <= 8; i++)
if ((b & (1 << i - 1)) != 0) count++;

return count;
}
  }
      }
