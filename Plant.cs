using System;
namespace ZooClass
{/// <summary>
/// This code defines a class named Plant that inherits from the Animal class.
/// It adds a property to store the color of the plant.
/// The constructor initializes the properties of the plant object using the base class constructor and sets the Color property.
/// It also sets the Sound property to "No sound" since plants do not make sounds.
/// </summary>
    class Plant : Animal
    {
        public string Color { get; set; }

        public Plant(string species, string color)
            : base(species, 0, 0, false)
        {
            Color = color;
            Sound = "No sound";
        }
    }
}
