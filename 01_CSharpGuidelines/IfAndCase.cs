namespace _01_CSharpGuidelines
{
  public class IfAndCase
  {
    public bool MethodWithIf1(int someNumber)
    {
      if (someNumber > 5)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool MethodWithIf2(int someNumber)
    {
      if (someNumber > 5) return true;

      return false;
    }

    public bool MethodWithIf3(int someNumber)
    {
      return (someNumber > 5);
    }

    public bool MethodWithCase1(int someNumber)
    {
      bool returnValue;
      switch (someNumber)
      {
        case 2:
        case 3:
          returnValue = true;
          break;

        default:
          returnValue = false;
          break;
      }

      return returnValue;
    }

    public bool MethodWithCase2(int someNumber)
    {
      switch (someNumber)
      {
        case 2:
        case 3:
          return true;

        default:
          return false;
      }
    }

    public bool MethodWithCase3(int someNumber)
    {
      switch (someNumber)
      {
        case 2: return true;

        default: return false;
      }
    }
  }
}
