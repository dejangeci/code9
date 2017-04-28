namespace _03_Assignment
{
  public class DogShelter
  {
    public Dog ProvideDog(DogBreed breed, string name)
    {
      return new Dog(name, breed);
    }
  }
}
