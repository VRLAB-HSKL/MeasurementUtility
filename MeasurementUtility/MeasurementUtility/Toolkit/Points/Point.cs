using System;

namespace MeasurementUtility
{
    /// <inheritdoc/>
    public class Point: PointBase
    {
        public Point(String id, Coordinate coordinate) 
        {

        }

        /// <summary>
        /// Method for updating the wrapped T.
        /// </summary>
        /// <param name="coordinate">
        /// The coordinate. 
        /// Intended to get the T values from the Transform of an Unity GameObject.
        /// </param>
        public void UpdateCoordinate(Coordinate coordinate)
        {
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            throw new NotImplementedException();
        } 
    }
}
