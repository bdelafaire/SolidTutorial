using System;

namespace SolidTutorial.SingleResponsability.Bad
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name) { }
        public string GetAnimalName() { return Name; }
        public void saveAnimal(Animal animal) { }
    }
}
