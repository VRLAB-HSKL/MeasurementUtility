using System;

namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for <see cref="Coordinate"/>.
    /// Intended to contain a Coordinate without the option to modify it.
    /// Used for visualization in Unity.
    /// </summary>
    public class Marker : PointBase
    {
        public Marker(String id, Coordinate coordinate)
        {
            ID = id;
            SetCoordinates(coordinate);
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
