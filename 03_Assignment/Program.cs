namespace _03_Assignment
{
  using System;

  class Program
  {
    static void Main(string[] args)
    {
      var shelter = new DogShelter();
      var dog1 = shelter.ProvideDog(DogBreed.Beagle, "Mr. Beagles");
      var dog2 = shelter.ProvideDog(DogBreed.GreatDane, "Louie");

      var person1 = new Person("John Doe", 1990);

      person1.AdoptDog(dog1);
      person1.AdoptDog(dog2);

      Console.WriteLine($"{person1.Name} is {person1.GetAgeInYears()} years old and owns {person1.OwnedDogCount} dog(s).");

      if (person1.OwnedDogCount > 0)
      {
        Console.WriteLine($"Dog(s) owned by {person1.Name}:");
        foreach (var name in person1.GetDogNames())
        {
          Console.WriteLine($"-{name}");
        }
      }
    }
  }
}

/*
Person
    Name (Property)
    Birth year (Property)
    Age in years (Calculated property or method)
    Adopt dog (Method that takes a Dog as parameter)
    Number of owned dogs (Calculated property or method)

Dog
    Name (Property)
    Breed (Only 4 breeds: Pug, Beagle, GreatDane, Maltese) (Property)

DogShelter
    Instantiates Dogs (Method, accepts name and breed)

Assignment
    Create a person
    Create a shelter
    Get several dogs from shelter
    Have the person adopt the dogs
    Write out in console: “NAME is X years old and owns Y dog(s).”
    (Bonus) If person has more than 0 dogs, write out in console: “Dog(s) owned by NAME:“
        (Write each dog’s name on a new line in console)

Notes:
    Persons name: cannot change
    Dogs name: can be changed
    Birth dates and breed cannot be changed after creation
*/
