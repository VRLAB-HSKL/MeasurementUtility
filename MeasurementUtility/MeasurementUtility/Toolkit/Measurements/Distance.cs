using Newtonsoft.Json.Linq;
using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Gets initialized and acts then as a Container.
    /// </summary>
    public class Distance : Measurement 
    {
        public Distance(string id, Coordinate start, Coordinate end, float result)
        {
            this.numberOfCoordinates = 2;
            this.ID = id; 
            SetCoordinates(start, end);
            this.Result= new FloatWrapper(result);
        }
        public Distance(JObject obj)
        {
            this.numberOfCoordinates = 2;
            this.ID = (string) obj["Distance"]["ID"];
            SetCoordinates(new Coordinate((JObject) obj["Distance"]["Start"]),
                new Coordinate((JObject) obj["Distance"]["End"]));
            this.Result = new FloatWrapper((JObject) obj["Distance"]["Result"]);
        }

        public override JObject ToJObject()
        {
            return JObject.Parse(this.ToJson());
        }

        public override string ToJson()
        {
            return "{\"Distance\":" + "{\"ID\": " + ID + "," 
                + "\"Start\":" + coordinates[0] + ","
                + "\"End\":" + coordinates[1] + ","
                + "\"Result\":" + Result.ToJson() +"}}";
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return ToJson();
        }    
    }
}
