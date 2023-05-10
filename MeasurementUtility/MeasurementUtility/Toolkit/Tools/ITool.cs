namespace MeasurementUtility
{
    public interface ITool
    {
        /// <summary>
        /// Method used to set the Measurement result.
        /// </summary>
        /// <returns>Measurement created by the corresponding tool</returns>
        void Measure(params Coordinate[] args);

        /// <summary>
        /// Getter for the Measurement stored in a tool.
        /// </summary>
        /// <returns>A Measurement container</returns>
        Measurement CreateMeasurement();
    }
}
