﻿using System;

namespace MeasurementUtility
{
    /// <summary>
    /// The abstracted form of a tool.
    /// </summary>
    /// <typeparam name="MeasurementType"></typeparam>
    public abstract class Tool<MeasurementType>: JsonConverter, ITool where MeasurementType : Measurement
    {
        protected int capacity { get; set; }

        /// <summary>
        /// The type of Measurement created by this tool.
        /// </summary>
        private MeasurementType measurement;
        public MeasurementType Measurement
        {
            get => measurement;
            protected set => measurement = value;
        }

        /// <inheritdoc/>
        public abstract Measurement CreateMeasurement();

        /// <inheritdoc/>
        public abstract void Measure(string id, params Coordinate[] args);

        //kann weg
        /// <inheritdoc/>
        public abstract override string ToString();
    }
}
