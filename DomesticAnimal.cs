using System;


namespace ZooClass
{/// <summary>
/// This code defines a class named DomesticAnimal that inherits from the Animal class.
/// It adds a property to store the owner of the domestic animal.
/// The constructor initializes the properties of the domestic animal object using the base class constructor and sets the Owner property.
/// </summary>
    class DomesticAnimal : Animal
    {
        public string Owner { get; set; }

        public DomesticAnimal(string species, int age, double weight, string owner)
            : base(species, age, weight, false)
        {
            Owner = owner;
        }
    }
}
