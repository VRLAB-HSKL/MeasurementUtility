using System;

namespace MeasurementUtility.Global
{
    public static class Formulary
    {

        public static double Distance(Toolkit.Coordinate c1, Toolkit.Coordinate c2)
        {
            return Math.Sqrt(Math.Pow(c2.x - c1.x, 2) + Math.Pow(c2.y - c1.y, 2) + Math.Pow(c2.z - c1.z, 2));
        }

    }
}
