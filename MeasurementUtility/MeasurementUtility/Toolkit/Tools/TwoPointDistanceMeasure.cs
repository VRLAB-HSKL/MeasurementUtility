using Newtonsoft.Json.Linq;
using System;

namespace MeasurementUtility
{
    /// <summary>
    /// The specialized tool for Distance measureing.
    /// Class representing a tool, measuring distance.
    /// </summary>
    public class TwoPointDistanceMeasure : Tool<Distance>
    {
        public TwoPointDistanceMeasure(string id)
        {
            capacity = 2;
            this.ID = LogAssistant.TOOL_ID + id;
        }

        // nochmal anschauen -> evtl in super class verschieben
        /// <inheritdoc/>
        public override Measurement CreateMeasurement()
        {
            return this.Measurement;
        }

        /// <inheritdoc/>
        public override void Measure(string measurementId, Coordinate[] coordinates)
        {
            if (coordinates.Length != capacity)
            {
                throw new ArgumentOutOfRangeException(nameof(coordinates));
            }
            else
            {
                this.Measurement = new Distance(measurementId, coordinates[0], coordinates[1], (float)Formulary.CalculateDistance(coordinates[0], coordinates[1]));
            }          
        }

        /// <inheritdoc/>
        public override JObject ToJObject()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public override string ToJson()
        {
            throw new NotImplementedException();
        }

        public override void FromJObject(JObject jobj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override void FromJson(string json)
        {
            throw new NotImplementedException();
        }
    }
}
