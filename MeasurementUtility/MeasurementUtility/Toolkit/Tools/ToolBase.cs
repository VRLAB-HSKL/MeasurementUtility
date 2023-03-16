using System;

namespace MeasurementUtility
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ToolBase<T> : CoordinateWrapper, ITool
    {
        /// <summary>
        /// 
        /// </summary>
        private T measurement;
        public T Measurement
        {
            get => measurement;
            protected set => measurement = value;
        }

        public abstract IMeasurement CreateMeasurement();

        /// <inheritdoc/>
        public abstract void Measure();

        /// <inheritdoc/>
        public abstract override string ToString();

        public abstract void UpdateCoordinates(params Coordinate[] args);
    }
}
