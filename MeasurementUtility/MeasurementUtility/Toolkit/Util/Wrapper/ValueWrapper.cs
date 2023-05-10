namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for a single data type. 
    /// This class is used to implement the different measurement value types of a measurement.
    /// </summary>
    public abstract class ValueWrapper
    {
        public override abstract string ToString();
        public abstract string ToJson();
    }
}
