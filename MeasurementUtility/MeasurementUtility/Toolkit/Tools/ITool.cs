namespace MeasurementUtility
{
    //TODO: depricated? update Tool? Used for Tool List with different Measurement types?
    public interface ITool
    {
        /// <summary>
        /// Method used to set the Measurement result.
        /// </summary>
        /// <returns>Measurement created by the corresponding tool</returns>
        void Measure(string id, params Coordinate[] args);

        /// <summary>
        /// Getter for the Measurement stored in a tool.
        /// </summary>
        /// <returns>A Measurement container</returns>
        Measurement CreateMeasurement();
    }
}
