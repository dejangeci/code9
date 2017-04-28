namespace _03_Assignment
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Person
  {
    public string Name { get; private set; }
    public int BirthYear { get; private set; }

    public int OwnedDogCount
    {
      get { return ownedDogs.Count; }
    }

    private readonly List<Dog> ownedDogs = new List<Dog>();

    public Person(string name, int birthYear)
    {
      Name = name;
      BirthYear = birthYear;
    }

    public int GetAgeInYears()
    {
      return DateTime.Now.Year - BirthYear;
    }

    public void AdoptDog(Dog dog)
    {
      ownedDogs.Add(dog);
    }

    public List<string> GetDogNames()
    {
      return ownedDogs.Select(d => d.Name).ToList();
    }
  }
}
