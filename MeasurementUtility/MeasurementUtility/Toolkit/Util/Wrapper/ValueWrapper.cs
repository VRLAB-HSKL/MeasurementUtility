using Newtonsoft.Json.Linq;

namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for a single data type. 
    /// This class is used to implement the different measurement value types of a measurement.
    /// </summary>
    public abstract class ValueWrapper
    {
        public object Value { get; set; }

        //public void SetValue<T>(T a)
        //{
        //    Value = a;
        //}

        public override abstract string ToString();

        /// <summary>
        /// Creates a JSON string with the data necessary for the corresponding object.
        /// </summary>
        /// <returns>The resulting string vlaue</returns>
        public abstract string ToJson();

        /// <summary>
        /// Transforms the JSON string to an JObject.
        /// </summary>
        /// <returns>JObject</returns>
        public abstract JObject ToJObject();
    }
}
