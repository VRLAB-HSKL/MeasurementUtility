using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUtility
{
    public class EmptyMeasurement : Measurement
    {
        public EmptyMeasurement()
        {
            SetupEmpty();
        }

        public EmptyMeasurement(JObject obj)
        {
            SetupEmpty();
        }

        void SetupEmpty()
        {
            this.numberOfCoordinates = 0;
            this.ID = "-1";
            this.Result = new FloatWrapper(float.NaN);     
        }

        public override JObject ToJObject()
        {
            return JObject.Parse(this.ToJson());
        }

        public override string ToJson()
        {
            return "{\"Empty\":" + "{\"ID\": -1,"
                + "\"Result\":" + Result.ToJson() + "}}";
        }

        public override string ToString()
        {
            return ToJson();
        }
    }
}
