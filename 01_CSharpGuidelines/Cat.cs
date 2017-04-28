namespace _01_CSharpGuidelines
{
  public class Cat : Animal
  {
    private const int STANDARD_CAT_LEG_COUNT = 4;

    public Cat()
      : base(STANDARD_CAT_LEG_COUNT)
    {
    }

    public void Meow()
    {
      // ...
    }
  }
}
