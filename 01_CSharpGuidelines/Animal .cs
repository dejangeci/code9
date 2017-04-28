namespace _01_CSharpGuidelines
{
  public abstract class Animal
  {
    public int LegCount { get; private set; }

    public Animal(int legCount)
    {
      LegCount = legCount;
    }
  }
}
