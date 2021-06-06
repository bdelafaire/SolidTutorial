using System;

namespace SolidTutorial.LiskovSubstitution.Good
{
    public abstract class WildLife
    {
        public string Name { get; set; }

        public virtual void Born()
        {
            //Born
        }
    }

    public class Snake : WildLife
    {
        public void Crawl()
        {
            // Crawl
        }
    }

    public class Human : WildLife
    {
        public void Walk()
        {
            // Walk
        }
    }
}
