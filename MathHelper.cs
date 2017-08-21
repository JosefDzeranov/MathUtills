using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtills
{
    public static class MathHelper
    {
        // Returns the square of a right triangle.
        public static double GetRightTriangleSquare(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new InvalidOperationException("Triangle does not exist.");
            }

            if (a * a + b * b == c * c)
            {
                return a * b / 2;
            }

            if (a * a + c * c == b * b)
            {
                return a * c / 2;
            }

            if (c * c + b * b == a * a)
            {
                return c * b / 2;
            }

            throw new InvalidOperationException("Triangle is not right.");
        }
    }
}
