namespace MeasurementUtility
{
    //TODO: For xml
    /// <summary>
    /// This class defines the base of every measurement. It's adds a wrapper for the result
    /// of the measurement to a class.
    /// </summary>
    public abstract class Measurement : CoordinateWrapper, IMeasurement
    {
        private ValueWrapper result;

        public ValueWrapper Result 
        {
            get => result;
            protected set => result = value; 
        }

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
