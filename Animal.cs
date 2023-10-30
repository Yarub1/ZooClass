using System;

namespace ZooClass
{/// <summary>
/// This code defines a class named Animal. It represents a generic animal and has properties to store common characteristics such as species, age, weight
/// whether it is wild or not, and the sound it makes. It also has methods to perform common actions like eating, sleeping, and making a sound.
/// The constructor is used to initialize the properties of an animal object when it is created.
/// </summary>
    class Animal
    {
        //characteristics
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public bool IsWild { get; set; }
        public string Sound { get; set; }

        // Constructor to create an Animal
        public Animal(string species, int age, double weight, bool isWild)
        {
            Species = species;
            Age = age;
            Weight = weight;
            IsWild = isWild;
            Sound = "Generic animal sound";
        }


        // methods
        public void Eat()
        {
            Console.WriteLine($"{Species} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Species} is sleeping.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Species} makes a {Sound}.");
        }
    }

}
