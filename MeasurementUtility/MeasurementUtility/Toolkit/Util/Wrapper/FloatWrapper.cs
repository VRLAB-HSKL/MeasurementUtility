using Newtonsoft.Json.Linq;
using NUnit.Framework.Constraints;

namespace MeasurementUtility
{
    /// <inheritdoc/>
    public class FloatWrapper: ValueWrapper
    {
        public FloatWrapper(float value)
        {
            Value = value;
        }
        public FloatWrapper(JObject obj)
        {
            Value = (float) obj["Value"];
        }

        public override void FromJObject(JObject obj)
        {
            throw new System.NotImplementedException();
        }

        public override void FromJson(string json)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public override JObject ToJObject()
        {
            return JObject.Parse(this.ToJson());
        }

        /// <inheritdoc/>
        public override string ToJson()
        {
            return "{\"Value\":" + Value + "}";
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "{ float: " + Value + " }";
        }
    }
}
