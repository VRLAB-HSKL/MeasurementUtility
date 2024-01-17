using Newtonsoft.Json.Linq;

namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for a single data type. 
    /// This class is used to implement the different measurement value types of measurements.
    /// </summary>
    public abstract class ValueWrapper: JsonConverter
    {
        /// <summary>
        /// The property of type object allows the usage of any data type without the use of
        /// a generic one.
        /// </summary>
        public object Value { get; set; }

        //public override abstract string ToString();
    }
}
