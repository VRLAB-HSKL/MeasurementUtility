using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasurementUtility.Toolkit.Tools
{
    public class TapeMeasure : ToolBase<Distance>
    {
        public TapeMeasure(String id, Coordinate start, Coordinate end)
        {
            ID = id;
            SetArguments(start, end);
        }

        public override Distance Measure()
        {
            return new Distance(ID + " Measurement:", args[0], args[1]);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
