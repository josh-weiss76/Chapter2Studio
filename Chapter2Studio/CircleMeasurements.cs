using System;

namespace Chapter2Studio
{
    public class CircleMeasurements
    {
        public static double CircleArea (float radius)
        {
            double areaOfACircle = (Math.Pow(radius, 2.0) * Math.PI);
            return Math.Round(areaOfACircle, 3);
        }
        public static double CircleCircumference (float radius)
        {
            double circumferenceOfACircle = (radius * 2 * Math.PI);
            return Math.Round(circumferenceOfACircle, 3);
        }
        public static double CircleDiameter (float radius)
        {
            double diameterOfACircle = (2 * radius);
            return Math.Round(diameterOfACircle, 3);
        }

    }
}
