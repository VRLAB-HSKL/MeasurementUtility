using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Class representing a tool, measuring distance.
    /// </summary>
    public class TapeMeasure : ToolBase<float>
    {
        public TapeMeasure(string id)
        {
            this.numberOfCoordinates = 2;
            this.ID = LogAssistant.TOOL_ID + id;
        }

        public override IMeasurement CreateMeasurement()
        {
            Measure();
            return new Distance(ID, coordinates[0], coordinates[1], this.Measurement);
        }

        public override void Measure()
        {
            this.Measurement = (float) Formulary.CalculateDistance(coordinates[0], coordinates[1]);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 2 variables needed! 
        /// </summary>
        /// <param name="args"></param>
        public override void UpdateCoordinates(params Coordinate[] args)
        {
            SetCoordinates(args);
        }
    }
}
