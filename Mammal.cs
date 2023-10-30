using System;
namespace ZooClass
{/// <summary>
/// This code defines a class named Mammal that inherits from the Animal class.
/// It adds a property to store whether the mammal has fur or not.
/// The constructor initializes the properties of the mammal object using the base class constructor and sets the HasFur property.
/// It also adds a new method GiveBirth() to represent the unique behavior of mammals giving birth to live young.
/// </summary>
    class Mammal : Animal
    {
        public bool HasFur { get; set; }

        public Mammal(string species, int age, double weight, bool hasFur)
            : base(species, age, weight, true)
        {
            HasFur = hasFur;
        }

        // New method for mammals
        public void GiveBirth()
        {
            Console.WriteLine($"{Species} gives birth to live young.");
        }
    }

}
