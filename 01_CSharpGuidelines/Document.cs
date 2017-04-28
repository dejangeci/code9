namespace _01_CSharpGuidelines
{
  using System.IO;

  public class Document
  {
    private string originalFilePath;

    public int PageCount { get; private set; }

    public void Open(string fullFilePath)
    {
      originalFilePath = fullFilePath;

      var filename = Path.GetFileName(fullFilePath);
      var pathRoot = Path.GetPathRoot(fullFilePath);

      // ...
    }

    public void Save()
    {
      // ...
    }
  }
}
