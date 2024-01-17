using Newtonsoft.Json.Linq;

namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class JsonConverter
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        public abstract void FromJson(string json);

        /// <summary>
        /// This function is meant to be used in a constructer, in order to initialize a
        /// measurement from a JObject.
        /// </summary>
        /// <param name="obj"></param>
        public abstract void FromJObject(JObject obj);
    }
}
