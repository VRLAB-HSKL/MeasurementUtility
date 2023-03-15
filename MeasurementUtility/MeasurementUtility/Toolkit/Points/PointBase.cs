namespace MeasurementUtility
{
    /// <summary>
    /// Wrapper for <see cref="Coordinate"/>. intended for Unity.
    /// </summary>
    public abstract class PointBase : ClassSetupBase
    {
        /// <summary>
        /// Returns the Coordinate wrapped.
        /// </summary>
        /// <returns>Coordinate</returns>
        public Coordinate GetCoordinate()
        {
            return args[0];
        }

        public abstract override string ToString();
    }
}
