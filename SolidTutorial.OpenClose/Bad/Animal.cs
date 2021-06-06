using System;

namespace SolidTutorial.OpenClose.Bad
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name) { }
        public string GetAnimalName() { return Name; }
        public void MakeSound()
        {
            if (Name == "Lion")
            {
                Console.WriteLine("GRRRRRRRRRR");
            }
            if (Name == "Mouse")
            {
                Console.WriteLine("Squeak");
            }
        }
    }
}
