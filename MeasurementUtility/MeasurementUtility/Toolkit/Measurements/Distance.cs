using System;

namespace MeasurementUtility
{
    public class Distance : MeasurementBase<float>
    {
        public Distance(String id, Coordinate start, Coordinate end)
        {
            ID = id;
            SetArguments(start, end);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return ID + "The Distance between " + args[0] + " and " + args[1] + " is " + CalculateMeasurement();
        }

        /// <inheritdoc/>
        public override float CalculateMeasurement()
        {
            return (float) Formulary.CalculateDistance(args[0], args[1]);
        }

        
    }
}
