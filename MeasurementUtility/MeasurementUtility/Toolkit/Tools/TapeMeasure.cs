using Newtonsoft.Json.Linq;
using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Class representing a tool, measuring distance.
    /// </summary>
    public class TapeMeasure : Tool<Distance>
    {
        public TapeMeasure(string id)
        {
            CAPACITY = 2;
            this.ID = LogAssistant.TOOL_ID + id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Measurement CreateMeasurement()
        {
            return this.Measurement;
        }

        public override void Measure(Coordinate[] coordinates)
        {
            if (coordinates.Length != CAPACITY)
            {
                throw new System.ArgumentOutOfRangeException(nameof(coordinates));
            }
            else
            {
                this.Measurement = new Distance(ID, coordinates[0], coordinates[1], (float)Formulary.CalculateDistance(coordinates[0], coordinates[1]));
            }          
        }

        public override JObject ToJObject()
        {
            throw new NotImplementedException();
        }

        public override string ToJson()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
