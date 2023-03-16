namespace MeasurementUtility
{
    public interface ITool
    {
        /// <summary>
        /// Method used to set the MeasurementBase result.
        /// </summary>
        /// <returns>Measurement created the corresponding tool</returns>
        void Measure();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IMeasurement CreateMeasurement();

        void UpdateCoordinates(params Coordinate[] args);
    }
}
