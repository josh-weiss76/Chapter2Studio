using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter2Studio
{
    class Roadtrip
    {
        public static double GallonsPerTrip(double circumference, float milesPerGallon)
        {
            double gallonsUsed = circumference / milesPerGallon;
            return Math.Round(gallonsUsed, 3);
        }
    }
}
