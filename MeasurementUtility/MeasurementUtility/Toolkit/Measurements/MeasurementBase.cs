namespace MeasurementUtility
{
    /// <summary>
    /// This class defines the base of every measurement, primarily their calculation.
    /// </summary>
    /// <typeparam name="T">Datatype of the measurement</typeparam>
    public abstract class MeasurementBase<T> : ClassSetupBase
    {
        /// <summary>
        /// Protected method for every Measurement. Defines the calculation of the Measurement.
        /// </summary>
        /// <returns>Value of type T.</returns>
        public abstract T CalculateMeasurement();

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
