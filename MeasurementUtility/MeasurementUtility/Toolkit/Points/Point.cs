using System;

namespace MeasurementUtility
{
    public class Point: PointBase
    {
        public Point(String id, Coordinate coordinate) 
        {
            ID = id;
            SetArguments(coordinate);
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
