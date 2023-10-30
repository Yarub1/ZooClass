using System;
namespace ZooClass
{/// <summary>
 /// This code defines a class named Human that inherits from the Animal class.
 /// It adds a property to store the nationality of the human.
 /// The constructor initializes the properties of the human object using the base class constructor and sets the sound to "Speaking".
 /// </summary>
 class Human : Animal
 {
     public string Nationality { get; set; }

     public Human(string species, int age, double weight)
         : base(species, age, weight, false)
     {
         Sound = "Speaking";
     }
 }

}
