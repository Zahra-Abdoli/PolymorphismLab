using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle:Shape
    {
        public Circle(int riduse)
        {
            Riduse = riduse;
        }
        private int riduse;

        public int Riduse
        {
            get { return riduse; }
            set { riduse = value; }
        }
        public override double CalculatePerimeter() =>  riduse*riduse;
        public override double CalculateArea() => riduse*riduse/2;
        public override string Draw() => "Drawing";
    }


}
}
