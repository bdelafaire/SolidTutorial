using System;
using System.Collections.Generic;
using System.Text;

namespace SolidTutorial.InterfaceSegregation.Bad
{
    public interface IShape
    {
        void DrawCircle();
        void DrawSquare();
        void DrawRectangle();
        void GetArea();
        void GetPerimeter();
    }

    class Circle : IShape
    {
        public void DrawCircle()
        {
            // Draw
        }

        public void DrawRectangle()
        {
            throw new NotImplementedException();
        }

        public void DrawSquare()
        {
            throw new NotImplementedException();
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
    class Square : IShape
    {
        public void DrawCircle()
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle()
        {
            throw new NotImplementedException();
        }

        public void DrawSquare()
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
    class Rectangle : IShape
    {
        public void DrawCircle()
        {
            throw new NotImplementedException();
        }

        public void DrawRectangle()
        {
            // Draw
        }

        public void DrawSquare()
        {
            throw new NotImplementedException();
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
