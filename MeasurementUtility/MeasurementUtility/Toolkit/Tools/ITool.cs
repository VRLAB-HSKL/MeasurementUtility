namespace MeasurementUtility
{
    public interface ITool
    {
        /// <summary>
        /// Method used to set the Measurement result.
        /// </summary>
        /// <returns>Measurement created the corresponding tool</returns>
        void Measure(params Coordinate[] args);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Measurement CreateMeasurement();
    }
}
