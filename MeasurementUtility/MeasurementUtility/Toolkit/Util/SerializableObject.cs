using Newtonsoft.Json.Linq;

namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class SerializableObject
    {
        /// <summary>
        /// ID of the object.
        /// </summary>
        private string id;
        public string ID
        {
            get => id;
            protected set => id = value;
        }

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
