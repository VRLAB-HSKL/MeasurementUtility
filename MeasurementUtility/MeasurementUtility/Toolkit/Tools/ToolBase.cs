using System;

namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="MeasurementType"></typeparam>
    public abstract class ToolBase<MeasurementType>: SerializableObject, ITool where MeasurementType : Measurement
    {
        protected int CAPACITY { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private MeasurementType measurement;
        public MeasurementType Measurement
        {
            get => measurement;
            protected set => measurement = value;
        }

        public abstract Measurement CreateMeasurement();

        /// <inheritdoc/>
        public abstract void Measure(params Coordinate[] args);

        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
