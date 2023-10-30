using System;
namespace ZooClass
{/// <summary>
/// This code defines a class named Reptile that inherits from the Animal class.
/// It adds a property to store whether the reptile is cold-blooded or not.
/// The constructor initializes the properties of the reptile object using the base class constructor and sets the IsColdBlooded property.
/// It also adds a new method LayEggs() to represent the unique behavior of reptiles laying eggs.
/// </summary>
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public Reptile(string species, int age, double weight, bool isColdBlooded)
            : base(species, age, weight, true)
        {
            IsColdBlooded = isColdBlooded;
        }

        // New method for reptiles
        public void LayEggs()
        {
            Console.WriteLine($"{Species} lays eggs.");
        }
    }

}
