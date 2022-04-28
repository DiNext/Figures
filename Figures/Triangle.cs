using System;

namespace Figures
{
    public static class Triangle
    {
        public static double Area(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Sides should be greater then 0");

            }

            double _p = (SideA + SideB + SideC) / 2;
            double _s = Math.Sqrt(_p * (_p - SideA) * (_p - SideB) * (_p - SideC));

            return _s;
        }

        public static bool IsRectangular(double SideA, double SideB, double SideC)
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
            {
                throw new ArgumentException("Sides should be greater then 0");

            }
             
            if(Math.Pow(SideC, 2) > Math.Pow(SideA, 2) + Math.Pow(SideB, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
