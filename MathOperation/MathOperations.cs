using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MathOperation
{
    class MathOperations
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b, double c) => a + b + c;
        public Decimal Add(decimal a,decimal b,decimal c) => a + b+c;

    }
}
