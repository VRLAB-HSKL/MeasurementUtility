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

        public abstract string ToJson();
        public abstract JObject ToJObject();
    }
}
