using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTutorial.DependencyInversion.Good
{
    interface Logger
    {
        void log(String msg);
    }

    class ConsoleLogger : Logger
    {
      public void log(String msg)
        {
            Console.WriteLine(msg);
        }
    }

    class SomeService
    {
        private Logger _logger;

        public SomeService(Logger logger)
        {
            _logger = logger;
        }

        public void someMethod()
        {
            _logger.log("Hi!");
        }
    }
}
