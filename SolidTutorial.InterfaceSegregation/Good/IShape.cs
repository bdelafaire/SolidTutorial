using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTutorial.InterfaceSegregation.Good
{
    public interface IShape
    {
        void GetArea();
        void GetPerimeter();
    }
    public interface ICircle : IShape
    {
        void DrawCircle();
    }

    public class Circle : ICircle
    {
        public void DrawCircle()
        {
            // Draw
        }

        public void GetArea()
        {
            // GetPerimeter
        }

        public void GetPerimeter()
        {
            // GetPerimeter
        }
    }


    public interface ISquare : IShape
    {
        void DrawCircle();
    }

    public class Square : ISquare
    {
        public void DrawCircle()
        {
            // Draw
        }

        public void GetArea()
        {
            // GetPerimeter
        }

        public void GetPerimeter()
        {
            // GetPerimeter
        }
    }

}
