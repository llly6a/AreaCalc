using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalc.Tests
{
    [TestClass()]
    public class AreaCalcTests
    {
        [TestMethod()]
        public void CalcArea_triangle_a10_b10_c10_43returned()
        {
            // arrange

            double a = 10.0;
            double b = 10.0;
            double c = 10.0;
            double expected = 43.301;

            Figure triangle = new Triangle(a, b, c);

            // act

            AreaCalc areaCalc = new AreaCalc();
            double actual = areaCalc.Calculate(triangle);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalcArea_circle_radius1_Pireturned()
        {
            // arrange

            double radius = 1.0;
            double expected = 3.142;

            Figure circle = new Circle(radius);

            // act

            AreaCalc areaCalc = new AreaCalc();
            double actual = areaCalc.Calculate(circle);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void isTriangleRight_a3_b4_c5_true()
        {
            // arrange

            double a = 3.0;
            double b = 4.0;
            double c = 5.0;

            Triangle triangle = new Triangle(a, b, c);

            //assert

            Assert.IsTrue(triangle.isRight());
        }
    }
}