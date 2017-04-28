namespace _01_CSharpGuidelines
{
  public class Comments
  {
    /// <summary>
    /// This will show up in intellisense. It is method documentation.
    /// </summary>
    /// <param name="myNumber">Wow, parameter description.</param>
    public int CommentExample(int myNumber)
    {
      // A single line comment, should always start with a space
      int num = 10;

      /*
       * A multiline comment.
       * Good for describing something
       * that requires more text.
       * Looks like this
       */
      int num2 = num + myNumber;

      return num2;
    }

    public void IntellisenseTest()
    {
      CommentExample(3);
    }
  }
}
