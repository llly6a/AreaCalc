using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Triangle : Figure
    {
        // lenghts of triangle sides
        double a;
        double b;
        double c;

        public Triangle(double _a, double _b, double _c)
        {
            if(_a <= 0 || _b <= 0 || _c <= 0)
            {
                throw new Exception("Сторона треугольника не может быть меньше либо равна нулю!");
            }

            if (_a + _b < _c || _a + _c < _b || _b + _c < _a)
            {
                throw new Exception("Треугольник не существует!");
            }

            a = _a;
            b = _b;
            c = _c;
        }

        public override double CalcArea()
        {
            // Heron's formula
            double p = (a+b+c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),3);
        }

        public bool isRight()
        {
            if (a == Math.Sqrt(b * b + c * c) || b == Math.Sqrt(a * a + c * c) || c == Math.Sqrt(b * b + a * a))
                return true;
            else
                return false;
        }
    }
}
