using System;

namespace Figures
{
    public static class Circle
    {
        public static double Area(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius should be greater then 0");
            }

            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
