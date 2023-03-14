namespace MeasurementUtility
{
    /// <summary>
    /// This class defines the base of every measurement, primarily their calculation.
    /// </summary>
    /// <typeparam name="T">Datatype of the measurement</typeparam>
    public abstract class MeasurementBase<T> : ClassSetupBase
    {
        /// <summary>
        /// Public method for every Measurement. Uses the <see cref="CalculateMeasurement"/>
        /// method in order to calculate a value.
        /// </summary>
        /// <returns>Value of type T.</returns>
        public T GetMeasurement()
        {
            return CalculateMeasurement();
        }

        // TODO: Necessary? Reduce to a single GetMeasurement method?
        /// <summary>
        /// Protected method for every Measurement. Defines the calculation of the Measurement.
        /// </summary>
        /// <returns>Value of type T.</returns>
        protected abstract T CalculateMeasurement();

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
