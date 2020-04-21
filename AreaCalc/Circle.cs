using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc
{
    public class Circle : Figure
    {
        double radius;

        public Circle(double _radius)
        {
            if (_radius <= 0)
            {
                throw new Exception("Радиус не может быть меньше либо равен нулю!");
            }

            radius = _radius;
        }

        public override double CalcArea()
        {
            return Math.Round(Math.PI * radius * radius, 3);
        }
    }
}
