namespace _03_Assignment
{
  public class Dog
  {
    public string Name { get; set; }
    public DogBreed Breed { get; private set; }

    public Dog(string name, DogBreed breed)
    {
      Name = name;
      Breed = breed;
    }
  }
}
