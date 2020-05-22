using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int haight,int width) :base()
        {
            Width = width;
            Height = height;

        }
        private int height;

        public int Height 
        {
            get { return height; }
            set { height = value; }
        }
        private int width;

        public int Width                
        {
            get { return width; }
            set { width = value; }
        }
        public override double  CalculatePerimeter() => height*width/2;
        public override double CalculateArea() => height * width;
        public override string Draw() => "Drawing";
    }
}
