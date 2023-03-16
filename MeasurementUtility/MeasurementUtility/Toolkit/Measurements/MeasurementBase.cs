namespace MeasurementUtility
{
    /// <summary>
    /// This class defines the base of every measurement. It's adds a wrapper for the result
    /// of the measurement to a class.
    /// </summary>
    /// <typeparam name="T">Datatype of the measurement</typeparam>
    public abstract class MeasurementBase<T> : CoordinateWrapper, IMeasurement
    {
        private T result;

        public T Result 
        {
            get => result;
            protected set => result = value; 
        }

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
