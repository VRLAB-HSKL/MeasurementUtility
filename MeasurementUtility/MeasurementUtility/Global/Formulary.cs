using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Manages the predefined Formulary for the entire dll. 
    /// This class is intended to exclusivly provide methods.
    /// </summary>
    public static class Formulary
    {
        public static double CalculateDistance(Coordinate c1, Coordinate c2)
        {
            return Math.Sqrt(Math.Pow(c2.x - c1.x, 2) + Math.Pow(c2.y - c1.y, 2) + Math.Pow(c2.z - c1.z, 2));
        }
    }
}
