using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTutorial.DependencyInversion.Bad
{
    class Logger
    {
        public void log(String msg)
        {
            Console.WriteLine(msg);
        }
    }

    class SomeService
    {
        private Logger logger;

        public SomeService()
        {
            logger = new Logger();
        }

        public void SomeMethod()
        {
            logger.log("Hi!");
        }
    }
}
