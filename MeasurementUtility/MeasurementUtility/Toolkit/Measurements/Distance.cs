using Newtonsoft.Json.Linq;
using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Gets initialized and acts then as a container for the measurement data.
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

        /// <summary>
        /// Distance constructor. Initializes a Distance object with a JObject.
        /// </summary>
        /// <param name="obj">JObject</param>
        public Distance(JObject obj)
        {
            this.numberOfCoordinates = 2;
            this.ID = (string) obj["Distance"]["ID"];
            SetCoordinates(new Coordinate((JObject) obj["Distance"]["Start"]),
                new Coordinate((JObject) obj["Distance"]["End"]));
            this.Result = new FloatWrapper((JObject) obj["Distance"]["Result"]);
        }

        /// <inheritdoc/>
        public override JObject ToJObject()
        {
            return JObject.Parse(this.ToJson());
        }

        /// <inheritdoc/>
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
