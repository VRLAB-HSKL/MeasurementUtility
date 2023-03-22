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

        public float Value { get; set; }

        public override string ToString()
        {
            return "{ float: " + Value + " }";
        }
    }
}
