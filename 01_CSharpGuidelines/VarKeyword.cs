namespace _01_CSharpGuidelines
{
  using System;

  public class VarKeyword
  {
    public void ExampleMethod()
    {
      var pageCount = 1;
      var word = "test";
      var someValue = 0.8235;
      var fido = new Dog();
      var barkResult = fido.Bark();
      var otherValue = SomeCalculation();

      int lineCount = 2;
      string otherWord = "test2";
      double anotherValue = 5.35;
      Dog fido2 = new Dog();
      bool barkResult2 = fido2.Bark();
      double result = SomeCalculation();

      // Ignore line below
      Console.WriteLine("", pageCount, word, someValue, otherValue, lineCount, otherWord, anotherValue, result);
    }

    public double SomeCalculation()
    {
      return Math.PI;
    }
  }
}
