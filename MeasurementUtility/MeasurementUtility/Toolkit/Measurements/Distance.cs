using System;

namespace MeasurementUtility
{
    /// <summary>
    /// restricted to two coordinates.
    /// Gets initialized and acts then as a Container.
    /// </summary>
    public class Distance : MeasurementBase<float>
    {
        public Distance(string id, Coordinate start, Coordinate end, float result)
        {
            this.numberOfCoordinates = 2;
            this.ID = id + LogAssistant.MEASUREMENT_ID + LogAssistant.MEASUREMENT_ID_DISTANCE; // Timestamp?
            SetCoordinates(start, end);
            this.Result= result;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return ID + coordinates[0] + " and " + coordinates[1] + " is " + Result;
        }    
    }
}
