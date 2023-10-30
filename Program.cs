using System;
using ZooClass;
class Program
{/// <summary>
/// This code defines the Program class, which contains the Main method.
/// The Main method is the entry point of the program.
/// It creates an array of Animal objects, including instances of Human, Mammal, Reptile, WildAnimal, DomesticAnimal, and Plant.
/// It then iterates over each animal in the zoo array and displays information about each animal, including its species, age, weight,
/// and whether it is wild or not. It also calls the Eat(), Sleep(), and MakeSound() methods for each animal to simulate their actions.
/// </summary>
    static void Main(string[] args)
{
    
        var zoo = new Animal[]
        {
            new Human("Human", 30, 70.0),
            new Mammal("Elephant", 15, 6000.0, true),
            new Reptile("Snake", 5, 10.0, true),
            new WildAnimal("Lion", 6, 180.0, "Savannah"),
            new DomesticAnimal("Dog", 3, 20.0, "John"),
            new Plant("Rose", "Red")
        };

        foreach (var animal in zoo)
        {
            Console.WriteLine($"*** {animal.Species} ***");
            Console.WriteLine($"Age: {animal.Age}, Weight: {animal.Weight}kg");
            if (animal is Plant)
            {
                Console.WriteLine($"Color: {(animal as Plant).Color}");
            }
            else
            {
                Console.WriteLine($"Is Wild: {animal.IsWild}");
            }

            animal.Eat();
            animal.Sleep();
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}
