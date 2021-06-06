using System;

namespace SolidTutorial.SingleResponsability.Good
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string name) { }
        public string GetAnimalName() { return Name; }
        
    }

    public class AnimalDB
    {
        public void saveAnimal(Animal animal) { }
    }

}
