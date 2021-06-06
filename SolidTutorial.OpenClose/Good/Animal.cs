using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTutorial.OpenClose.Good
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string GetAnimalName() { return Name; }
        public virtual void MakeSound()
        {
        }
    }

    public class Lion : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Grrrrrrrrr");
        }
    }

    public class Mouse : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
