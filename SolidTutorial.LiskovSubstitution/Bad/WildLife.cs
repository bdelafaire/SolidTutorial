using System;

namespace SolidTutorial.LiskovSubstitution.Bad
{
    public abstract class WildLife
    {
        public string Name { get; set; }

        public virtual void Walk() 
        {
            // Walk
        }
    }

    public class Snake : WildLife
    {
        public override void Walk()
        {
            throw new InvalidOperationException("Snake can't walk use Crawl() instead");
        }

        public void Crawl()
        {
            // Crawl
        }
    }
}
