namespace _01_CSharpGuidelines
{
  public class Dog : Animal
  {
    private const int STANDARD_DOG_LEG_COUNT = 4;

    public Dog()
      : base(STANDARD_DOG_LEG_COUNT)
    {
    }

    public bool Bark()
    {
      // ...

      return true;
    }
  }
}
