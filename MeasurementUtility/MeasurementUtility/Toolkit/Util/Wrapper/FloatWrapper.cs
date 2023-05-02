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

        public float Value { get; set; }

        public override string ToJson()
        {
            return "{\"Value\":" + Value + "}";
        }

        public override string ToString()
        {
            return "{ float: " + Value + " }";
        }
    }
}
