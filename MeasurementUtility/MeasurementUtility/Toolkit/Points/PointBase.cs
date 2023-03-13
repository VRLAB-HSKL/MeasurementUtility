namespace MeasurementUtility
{
    public abstract class PointBase : ClassSetupBase
    {
        public Coordinate GetCoordinate()
        {
            return args[0];
        }

        public void UpdateCoordinate(Coordinate coordinate)
        {
            SetArguments(coordinate);
        }

        public abstract override string ToString();
    }
}
