using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Class representing a tool, measuring distance.
    /// </summary>
    public class TapeMeasure : ToolBase<Distance>
    {
        public TapeMeasure(String id, Coordinate start, Coordinate end)
        {
            ID = id;
            SetArguments(start, end);
        }

        /// <inheritdoc/>
        public override Distance Measure()
        {
            return new Distance(ID + " Measurement:", args[0], args[1]);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
