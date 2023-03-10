namespace MeasurementUtility
{
    internal interface IPoint
    {
        void UpdateCoordinate(Coordinate coordinate);
        Coordinate GetCoordinate();
    }
}
