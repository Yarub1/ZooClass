using System;
namespace ZooClass
{/// <summary>
/// This code defines a class named WildAnimal that inherits from the Animal class. It adds a property to store the natural habitat of the wild animal.
/// The constructor initializes the properties of the wild animal object using the base class constructor and sets the NaturalHabitat property.
/// </summary>
    class WildAnimal : Animal
    {
        public string NaturalHabitat { get; set; }

        public WildAnimal(string species, int age, double weight, string habitat)
            : base(species, age, weight, true)
        {
            NaturalHabitat = habitat;
        }
    }

}
